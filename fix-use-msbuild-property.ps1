# Fix: Use custom MSBuild property instead of SolutionName detection
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Fixing MSBuild Condition (Use Property)" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$files = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"
$fixedCount = 0

# Pattern to find the current condition
$oldPattern = [regex]::Escape("`$([System.String]::Copy('`$(SolutionName)').IndexOf('Nuget')) &gt;= 0")

# New simple condition that checks for a custom property
$newCondition = "'`$(UseNuGetPackages)' == 'true'"

Write-Host "Scanning $($files.Count) project files..." -ForegroundColor Yellow
Write-Host ""
Write-Host "Changing approach:" -ForegroundColor Gray
Write-Host "  FROM: Check if SolutionName contains 'Nuget'" -ForegroundColor Red
Write-Host "  TO:   Check if UseNuGetPackages property is 'true'" -ForegroundColor Green
Write-Host ""
Write-Host "This allows workflows to control which references to use" -ForegroundColor Cyan
Write-Host ""

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    if ($content -match $oldPattern) {
        Write-Host "Fixing: $($file.Name)" -ForegroundColor Gray
        
        $newContent = $content -replace $oldPattern, $newCondition
        
        Set-Content -Path $file.FullName -Value $newContent -NoNewline
        $fixedCount++
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "Fixed $fixedCount project files" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host ""
Write-Host "New condition:" -ForegroundColor Yellow
Write-Host "  <When Condition=`"'`$(UseNuGetPackages)' == 'true'`">" -ForegroundColor Green
Write-Host ""
Write-Host "Usage in workflows:" -ForegroundColor Cyan
Write-Host "  msbuild Solution.sln /p:UseNuGetPackages=true /p:Configuration=Release" -ForegroundColor White
Write-Host ""
Write-Host "This will force NuGet packages instead of project references" -ForegroundColor Gray

