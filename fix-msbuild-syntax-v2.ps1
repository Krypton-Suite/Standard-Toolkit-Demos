# Fix MSBuild syntax - correct the parenthesis placement
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Fixing MSBuild Condition Syntax (v2)" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$files = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"
$fixedCount = 0

# The incorrect pattern we just created (parenthesis in wrong place)
$incorrectPattern = [regex]::Escape("'`$([System.String]::Copy('`$(SolutionName)').IndexOf('Nuget') &gt;= 0)'")

# The correct MSBuild property function syntax
$correctPattern = "`$([System.String]::Copy('`$(SolutionName)').IndexOf('Nuget')) &gt;= 0"

Write-Host "Scanning $($files.Count) project files..." -ForegroundColor Yellow
Write-Host ""
Write-Host "Fixing parenthesis placement:" -ForegroundColor Gray
Write-Host "  From: Condition=`"'`$([...].IndexOf('Nuget') >= 0)'`"" -ForegroundColor Red
Write-Host "  To:   Condition=`"`$([...].IndexOf('Nuget')) >= 0`"" -ForegroundColor Green
Write-Host ""

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    if ($content -match $incorrectPattern) {
        Write-Host "Fixing: $($file.Name)" -ForegroundColor Gray
        
        $newContent = $content -replace $incorrectPattern, $correctPattern
        
        Set-Content -Path $file.FullName -Value $newContent -NoNewline
        $fixedCount++
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "Fixed $fixedCount project files" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host ""
Write-Host "Correct MSBuild property function syntax:" -ForegroundColor Cyan
Write-Host "  `$([System.String]::Copy('`$(SolutionName)').IndexOf('Nuget')) >= 0" -ForegroundColor Green
Write-Host ""
Write-Host "The property function call is completed first, then compared" -ForegroundColor Gray

