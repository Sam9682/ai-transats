# Performance Monitor Script
Write-Host "=== System Performance Monitor ===" -ForegroundColor Green

# Memory Usage
$memory = Get-WmiObject -Class Win32_OperatingSystem
$totalRAM = [math]::Round($memory.TotalVisibleMemorySize/1MB, 2)
$freeRAM = [math]::Round($memory.FreePhysicalMemory/1MB, 2)
$usedRAM = [math]::Round(($memory.TotalVisibleMemorySize - $memory.FreePhysicalMemory)/1MB, 2)

Write-Host "Memory Usage:" -ForegroundColor Yellow
Write-Host "  Total: $totalRAM GB"
Write-Host "  Used:  $usedRAM GB ($([math]::Round(($usedRAM/$totalRAM)*100, 1))%)"
Write-Host "  Free:  $freeRAM GB"

# Top CPU Processes
Write-Host "`nTop CPU Processes:" -ForegroundColor Yellow
Get-Process | Sort-Object CPU -Descending | Select-Object -First 5 Name, CPU, @{Name="Memory(MB)";Expression={[math]::Round($_.WorkingSet/1MB,2)}} | Format-Table -AutoSize

# Check for .NET processes
$dotnetProcesses = Get-Process | Where-Object {$_.ProcessName -like '*dotnet*' -or $_.ProcessName -like '*TransactsWeb*'}
if ($dotnetProcesses) {
    Write-Host ".NET/Web Processes:" -ForegroundColor Yellow
    $dotnetProcesses | Format-Table Name, CPU, @{Name="Memory(MB)";Expression={[math]::Round($_.WorkingSet/1MB,2)}} -AutoSize
}

Write-Host "`nRun this script every 30 seconds to monitor performance" -ForegroundColor Green