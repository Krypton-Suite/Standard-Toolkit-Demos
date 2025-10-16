# Demonstration of WiX Version Update Process
# This simulates what the GitHub Actions workflow does

$separator = "=" * 60

Write-Host $separator -ForegroundColor Cyan
Write-Host "WiX Installer Dynamic Version Update Demo" -ForegroundColor Cyan
Write-Host $separator -ForegroundColor Cyan
Write-Host ""

# Simulate version generation
$version = "100.25.10.289"
$prereleaseSuffix = "-beta"  # Empty for release, "-beta" for nightly

Write-Host "Step 1: Generated Version" -ForegroundColor Yellow
Write-Host "  Version: $version"
Write-Host "  Suffix:  $prereleaseSuffix"
Write-Host ""

# Show what gets updated in Product.wxs files
Write-Host "Step 2: Update Product.wxs Files" -ForegroundColor Yellow
Write-Host "  Files to update:" -ForegroundColor Gray
$productFiles = @(
    "Source/WixInstaller/WixInstaller.net48/Product.wxs",
    "Source/WixInstaller/WixInstaller.net80/Product.wxs",
    "Source/WixInstaller/WixInstaller.net90/Product.wxs",
    "Source/WixInstaller/WixInstaller.net100/Product.wxs"
)

foreach ($file in $productFiles) {
    if (Test-Path $file) {
        Write-Host "    - $file" -ForegroundColor Gray
        
        # Read current content
        $content = Get-Content $file -Raw
        
        # Extract current version
        if ($content -match '\<\?define Version = "([^"]+)"') {
            $currentVersion = $matches[1]
            Write-Host "      Current: $currentVersion" -ForegroundColor DarkYellow
            Write-Host "      New:     $version" -ForegroundColor Green
        }
    } else {
        Write-Host "    - $file [NOT FOUND]" -ForegroundColor Red
    }
}
Write-Host ""

# Show what gets updated in .wixproj files
Write-Host "Step 3: Update .wixproj OutputName" -ForegroundColor Yellow
Write-Host "  Files to update:" -ForegroundColor Gray
$wixprojFiles = @(
    @{Path="Source/WixInstaller/WixInstaller.net48/WixInstaller.net48.wixproj"; Target="Net48"},
    @{Path="Source/WixInstaller/WixInstaller.net80/WixInstaller.net80.wixproj"; Target="Net80"},
    @{Path="Source/WixInstaller/WixInstaller.net90/WixInstaller.net90.wixproj"; Target="Net90"},
    @{Path="Source/WixInstaller/WixInstaller.net100/WixInstaller.net100.wixproj"; Target="Net100"}
)

foreach ($proj in $wixprojFiles) {
    $file = $proj.Path
    $target = $proj.Target
    
    if (Test-Path $file) {
        Write-Host "    - $file" -ForegroundColor Gray
        
        # Read current content
        $content = Get-Content $file -Raw
        
        # Extract current OutputName
        if ($content -match '<OutputName>([^<]+)</OutputName>') {
            $currentOutput = $matches[1]
            $newOutputName = "Samples.v$version$prereleaseSuffix.$target"
            Write-Host "      Current: $currentOutput" -ForegroundColor DarkYellow
            Write-Host "      New:     $newOutputName" -ForegroundColor Green
        }
    } else {
        Write-Host "    - $file [NOT FOUND]" -ForegroundColor Red
    }
}
Write-Host ""

# Show resulting MSI file names
Write-Host "Step 4: Build Results (MSI Files)" -ForegroundColor Yellow
Write-Host "  Generated installers:" -ForegroundColor Gray
$targets = @("Net48", "Net80", "Net90", "Net100")
foreach ($target in $targets) {
    $msiName = "Samples.v$version$prereleaseSuffix.$target.msi"
    Write-Host "    + $msiName" -ForegroundColor Green
}
Write-Host ""

Write-Host $separator -ForegroundColor Cyan
Write-Host "Summary:" -ForegroundColor Cyan
Write-Host "  Product.wxs Version:  $version" -ForegroundColor White
$outputPattern = "Samples.v{0}{1}.*.msi" -f $version, $prereleaseSuffix
Write-Host "  MSI Output Names:     $outputPattern" -ForegroundColor White
Write-Host $separator -ForegroundColor Cyan
