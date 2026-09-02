param([ValidateRange(1024,65535)][int]$Port = 5271, [string]$VaultRoot = '', [switch]$NoBrowser)
$ErrorActionPreference = 'Stop'
$wikiApp = [IO.Path]::GetFullPath($PSScriptRoot)
if (-not $VaultRoot) { $VaultRoot = [IO.Path]::GetFullPath((Join-Path $wikiApp '../..')) }
$wikiStateDirectory = Join-Path $wikiApp 'App_Data'
$wikiStatePath = Join-Path $wikiStateDirectory 'instance.json'
$wikiUrl = "http://localhost:$Port"
$wikiProject = Join-Path $wikiApp 'WorldEgg.Wiki.csproj'
$wikiAssembly = Join-Path $wikiApp 'bin/Release/net10.0/WorldEgg.Wiki.dll'
$wikiStarted = $null
try {
    if (Test-Path -LiteralPath $wikiStatePath) {
        $wikiPrevious = Get-Content -Raw -LiteralPath $wikiStatePath | ConvertFrom-Json
        try { $wikiHealth = Invoke-RestMethod "$($wikiPrevious.url)/health" -TimeoutSec 2 } catch { $wikiHealth = $null }
        if ($wikiHealth -and $wikiHealth.application -eq 'WorldEgg.Wiki' -and $wikiHealth.instance -eq $wikiPrevious.instance) {
            Write-Output "The reader is already running at $($wikiPrevious.url)."
            if (-not $NoBrowser) { Start-Process $wikiPrevious.url }
            exit 0
        }
    }
    $wikiProbe = New-Object Net.Sockets.TcpClient
    try {
        $wikiConnection = $wikiProbe.ConnectAsync('localhost', $Port)
        try { $null = $wikiConnection.Wait(1500) } catch { }
        if ($wikiProbe.Connected) { throw "Port $Port is occupied by another process. Nothing was stopped. Close that process yourself or use -Port with a different port." }
    } finally { $wikiProbe.Dispose() }
    $null = New-Item -ItemType Directory -Force -Path $wikiStateDirectory
    $wikiDotnet = (Get-Command dotnet.exe -ErrorAction Stop).Source
    if (-not (Test-Path -LiteralPath (Join-Path $wikiApp 'obj/project.assets.json'))) {
        & $wikiDotnet restore $wikiProject --locked-mode
        if ($LASTEXITCODE -ne 0) { throw 'Dependency restore failed. Initial setup needs Internet access and the .NET 10 SDK.' }
    }
    & $wikiDotnet build $wikiProject -c Release --no-restore --nologo
    if ($LASTEXITCODE -ne 0) { throw 'The reader could not build. See the messages above; no background process was started.' }
    $wikiToken = [Guid]::NewGuid().ToString('N')
    $wikiPreviousToken = $env:WORLDEGG_INSTANCE
    try {
        $env:WORLDEGG_INSTANCE = $wikiToken
        $wikiStarted = Start-Process -FilePath $wikiDotnet -ArgumentList @(('"' + $wikiAssembly + '"'), '--contentRoot', ('"' + $wikiApp + '"'), '--Wiki:VaultRoot', ('"' + $VaultRoot + '"'), '--Wiki:Port', $Port) -WorkingDirectory $wikiApp -WindowStyle Hidden -RedirectStandardOutput (Join-Path $wikiStateDirectory 'reader.log') -RedirectStandardError (Join-Path $wikiStateDirectory 'reader-error.log') -PassThru
    } finally { $env:WORLDEGG_INSTANCE = $wikiPreviousToken }
    $wikiDeadline = [DateTime]::UtcNow.AddSeconds(90)
    $wikiReady = $false
    Write-Output 'Opening the vault for reading...'
    while ([DateTime]::UtcNow -lt $wikiDeadline) {
        $wikiStarted.Refresh()
        if ($wikiStarted.HasExited) { throw "The reader exited during startup. See App_Data/reader-error.log. No unrelated process was stopped." }
        try {
            $wikiHealth = Invoke-RestMethod "$wikiUrl/health" -TimeoutSec 2
            if ($wikiHealth.instance -eq $wikiToken) { $wikiReady = $true; break }
        } catch { }
        Start-Sleep -Milliseconds 500
    }
    if (-not $wikiReady) { throw 'The reader did not become ready within 90 seconds. See App_Data/reader.log.' }
    @{ processId = $wikiStarted.Id; startedTicks = $wikiStarted.StartTime.ToUniversalTime().Ticks.ToString(); instance = $wikiToken; appRoot = $wikiApp; url = $wikiUrl } | ConvertTo-Json | Set-Content -LiteralPath $wikiStatePath -Encoding UTF8
    Write-Output "Ready: $wikiUrl ($($wikiHealth.articles) articles). Use Stop Wiki.cmd when finished."
    if (-not $NoBrowser) { Start-Process $wikiUrl }
} catch {
    if ($wikiStarted -and -not $wikiStarted.HasExited) { $wikiStarted.Kill() }
    Write-Error $_
    exit 1
}
