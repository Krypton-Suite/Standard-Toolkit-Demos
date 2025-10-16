# Fix MSBuild condition syntax - Replace Contains with proper MSBuild property function
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Fixing MSBuild Condition Syntax" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$files = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"
$fixedCount = 0

# The broken pattern we just created
$brokenPattern = [regex]::Escape("SolutionName.Contains('Nuget')")

# The correct MSBuild property function syntax using IndexOf
$correctPattern = '[System.String]::Copy(''$(SolutionName)'').IndexOf(''Nuget'') &gt;= 0'

Write-Host "Scanning $($files.Count) project files..." -ForegroundColor Yellow
Write-Host ""
Write-Host "Replacing:" -ForegroundColor Gray
Write-Host "  From: Condition=`"`$(SolutionName.Contains('Nuget'))`"" -ForegroundColor Red
Write-Host "  To:   Condition=`"`$($correctPattern)`"" -ForegroundColor Green
Write-Host ""

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    if ($content -match $brokenPattern) {
        Write-Host "Fixing: $($file.Name)" -ForegroundColor Gray
        
        # Replace the broken Contains syntax with proper MSBuild property function
        $newContent = $content -replace [regex]::Escape("`$(SolutionName.Contains('Nuget'))"), "`$($correctPattern)"
        
        Set-Content -Path $file.FullName -Value $newContent -NoNewline
        $fixedCount++
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "Fixed $fixedCount project files" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host ""
Write-Host "Technical Details:" -ForegroundColor Yellow
Write-Host "  MSBuild doesn't support .Contains() directly" -ForegroundColor Gray
Write-Host "  Using property function: [System.String]::Copy().IndexOf()" -ForegroundColor Gray
Write-Host "  IndexOf returns -1 if not found, >= 0 if found" -ForegroundColor Gray
Write-Host ""
Write-Host "New condition checks if 'Nuget' appears anywhere in solution name" -ForegroundColor Cyan

