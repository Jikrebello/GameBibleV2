$ErrorActionPreference = 'Stop'
$wikiApp = [IO.Path]::GetFullPath($PSScriptRoot)
$wikiStatePath = Join-Path $wikiApp 'App_Data/instance.json'
if (-not (Test-Path -LiteralPath $wikiStatePath)) { Write-Output 'No launcher-owned reader is recorded. Nothing was stopped.'; exit 0 }
$wikiRecord = Get-Content -Raw -LiteralPath $wikiStatePath | ConvertFrom-Json
if ($wikiRecord.appRoot -ne $wikiApp) { throw 'The instance record belongs to a different application directory. Nothing was stopped.' }
$wikiProcess = Get-Process -Id $wikiRecord.processId -ErrorAction SilentlyContinue
if ($wikiProcess -and $wikiProcess.StartTime.ToUniversalTime().Ticks.ToString() -eq $wikiRecord.startedTicks) {
    $wikiCommand = Get-CimInstance Win32_Process -Filter "ProcessId = $($wikiRecord.processId)"
    $wikiAssembly = Join-Path $wikiApp 'bin/Release/net10.0/WorldEgg.Wiki.dll'
    if (-not $wikiCommand.CommandLine.Contains($wikiAssembly)) { throw 'The process is not this reader. Nothing was stopped.' }
    Stop-Process -Id $wikiRecord.processId
    Write-Output 'Stopped this World Egg reader. The vault is unchanged.'
} else { Write-Output 'The recorded reader has already stopped. No other process was touched.' }
# Only remove this generated instance record, never a directory or source file.
Remove-Item -LiteralPath $wikiStatePath
