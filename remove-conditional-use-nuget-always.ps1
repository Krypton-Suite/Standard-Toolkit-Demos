# Remove the conditional - NuGet solutions should ALWAYS use NuGet packages
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Removing Conditional Logic" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

$files = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"
$fixedCount = 0

Write-Host "Scanning $($files.Count) project files..." -ForegroundColor Yellow
Write-Host ""
Write-Host "Strategy: Remove the entire <Choose> block and ONLY use NuGet packages" -ForegroundColor Cyan
Write-Host ""

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    # Check if it has the Choose block
    if ($content -match '<Choose>') {
        Write-Host "Fixing: $($file.Name)" -ForegroundColor Gray
        
        # Find the Choose block and replace it with just the NuGet PackageReferences
        # The pattern: <Choose>...<When>...<PackageReference>...</When><Otherwise>...</Otherwise></Choose>
        
        # Use regex to extract just the PackageReference items from the When block
        if ($content -match '<Choose>[\s\S]*?<When Condition[^>]*?>([\s\S]*?)</When>[\s\S]*?</Choose>') {
            $whenContent = $matches[1]
            
            # Replace the entire Choose block with just the When content
            $newContent = $content -replace '<Choose>[\s\S]*?</Choose>', $whenContent
            
            Set-Content -Path $file.FullName -Value $newContent -NoNewline
            $fixedCount++
        }
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "Fixed $fixedCount project files" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host ""
Write-Host "Result: All projects now ALWAYS use NuGet packages" -ForegroundColor Cyan
Write-Host "No more conditionals, no more Dev project references" -ForegroundColor Gray

