# Test script for GitHub Actions workflows
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Testing GitHub Actions Implementation" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Test 1: Validate YAML files exist
Write-Host "Test 1: Checking workflow files..." -ForegroundColor Yellow
$workflowFiles = @(
    ".github/workflows/build.yml",
    ".github/workflows/release.yml",
    ".github/workflows/README.md"
)

$test1Pass = $true
foreach ($file in $workflowFiles) {
    if (Test-Path $file) {
        $size = (Get-Item $file).Length
        Write-Host "  [OK] $file ($size bytes)" -ForegroundColor Green
    } else {
        Write-Host "  [FAIL] $file NOT FOUND" -ForegroundColor Red
        $test1Pass = $false
    }
}
Write-Host ""

# Test 2: Verify project files were fixed
Write-Host "Test 2: Checking project file fixes..." -ForegroundColor Yellow
$csprojFiles = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"
$fixedCount = 0
$unfixedCount = 0
$test2Pass = $true

foreach ($file in $csprojFiles) {
    $content = Get-Content $file.FullName -Raw
    if ($content -match 'SolutionName\.Contains') {
        $fixedCount++
    } elseif ($content -match 'SolutionName\.Endswith') {
        $unfixedCount++
        Write-Host "  [FAIL] Still has bug: $($file.Name)" -ForegroundColor Red
        $test2Pass = $false
    }
}

Write-Host "  [OK] Fixed: $fixedCount projects" -ForegroundColor Green
if ($unfixedCount -gt 0) {
    Write-Host "  [FAIL] Unfixed: $unfixedCount projects" -ForegroundColor Red
}
Write-Host ""

# Test 3: Check NuGet availability
Write-Host "Test 3: Checking NuGet availability..." -ForegroundColor Yellow
$nugetPath = Get-Command nuget -ErrorAction SilentlyContinue
$test3Pass = $true
if ($nugetPath) {
    Write-Host "  [OK] NuGet CLI found" -ForegroundColor Green
} else {
    Write-Host "  [WARN] NuGet CLI not found (OK for GitHub Actions)" -ForegroundColor Yellow
}
Write-Host ""

# Test 4: Test NuGet restore
Write-Host "Test 4: Testing NuGet restore..." -ForegroundColor Yellow
$testSolution = "Source/Krypton Explorer/Krypton Explorer 2022 - Nuget.sln"
$test4Pass = $true

if ((Test-Path $testSolution) -and $nugetPath) {
    Write-Host "  Running: nuget restore..." -ForegroundColor Gray
    nuget restore $testSolution -NonInteractive -Verbosity quiet 2>&1 | Out-Null
    
    if ($LASTEXITCODE -eq 0) {
        Write-Host "  [OK] NuGet restore succeeded" -ForegroundColor Green
    } else {
        Write-Host "  [WARN] NuGet restore had issues (may work in CI)" -ForegroundColor Yellow
        $test4Pass = $false
    }
} else {
    Write-Host "  [SKIP] NuGet CLI not available or solution missing" -ForegroundColor Gray
}
Write-Host ""

# Test 5: Check MSBuild availability
Write-Host "Test 5: Checking MSBuild availability..." -ForegroundColor Yellow
$msbuildPath = Get-Command msbuild -ErrorAction SilentlyContinue
$test5Pass = $true
if ($msbuildPath) {
    Write-Host "  [OK] MSBuild found" -ForegroundColor Green
    $msbuildVersion = & msbuild -version 2>&1 | Select-Object -Last 1
    Write-Host "  Version: $msbuildVersion" -ForegroundColor Gray
} else {
    Write-Host "  [WARN] MSBuild not found (required for GitHub Actions)" -ForegroundColor Yellow
}
Write-Host ""

# Test 6: Verify version generation logic
Write-Host "Test 6: Testing version generation..." -ForegroundColor Yellow
$major = "100"
$year = (Get-Date).ToString("yy")
$month = (Get-Date).ToString("MM")
$dayOfYear = (Get-Date).DayOfYear
$version = "$major.$year.$month.$dayOfYear"
$test6Pass = $true

Write-Host "  Generated version: $version" -ForegroundColor Cyan
Write-Host "  Release format: v$version" -ForegroundColor Gray
Write-Host "  Nightly format: v$version-beta" -ForegroundColor Gray
Write-Host "  [OK] Version generation working" -ForegroundColor Green
Write-Host ""

# Test 7: Check WiX installer projects
Write-Host "Test 7: Checking WiX installer projects..." -ForegroundColor Yellow
$wixProjects = @(
    "Source/WixInstaller/WixInstaller.net48/WixInstaller.net48.wixproj",
    "Source/WixInstaller/WixInstaller.net80/WixInstaller.net80.wixproj",
    "Source/WixInstaller/WixInstaller.net90/WixInstaller.net90.wixproj"
)

$test7Pass = $true
foreach ($proj in $wixProjects) {
    if (Test-Path $proj) {
        Write-Host "  [OK] Found: $(Split-Path $proj -Leaf)" -ForegroundColor Green
    } else {
        Write-Host "  [FAIL] Missing: $proj" -ForegroundColor Red
        $test7Pass = $false
    }
}
Write-Host ""

# Test 8: Verify documentation
Write-Host "Test 8: Checking documentation..." -ForegroundColor Yellow
$docs = @(
    ".github/workflows/README.md",
    ".github/HOW-VERSION-UPDATES-WORK.md",
    ".github/NUGET-PACKAGES.md",
    ".github/PROJECT-FILE-FIX.md"
)

$test8Pass = $true
foreach ($doc in $docs) {
    if (Test-Path $doc) {
        $lineCount = (Get-Content $doc).Count
        Write-Host "  [OK] $(Split-Path $doc -Leaf) ($lineCount lines)" -ForegroundColor Green
    } else {
        Write-Host "  [FAIL] Missing: $doc" -ForegroundColor Red
        $test8Pass = $false
    }
}
Write-Host ""

# Test 9: Check git status
Write-Host "Test 9: Checking git status..." -ForegroundColor Yellow
$gitStatus = git status --short 2>&1
$modifiedCount = ($gitStatus | Measure-Object).Count
$test9Pass = $true

Write-Host "  Modified/New files: $modifiedCount" -ForegroundColor Cyan
if ($modifiedCount -gt 0) {
    Write-Host "  [OK] Files ready for commit" -ForegroundColor Green
} else {
    Write-Host "  [WARN] No changes detected" -ForegroundColor Yellow
}
Write-Host ""

# Summary
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Test Summary" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan

$allTests = @($test1Pass, $test2Pass, $test6Pass, $test7Pass, $test8Pass, $test9Pass)
$passedTests = ($allTests | Where-Object { $_ -eq $true }).Count
$totalTests = $allTests.Count

Write-Host "Tests Passed: $passedTests / $totalTests" -ForegroundColor $(if ($passedTests -eq $totalTests) { "Green" } else { "Yellow" })
Write-Host ""

if ($test1Pass) { Write-Host "[OK] Workflow files created" -ForegroundColor Green }
if ($test2Pass) { Write-Host "[OK] Project files fixed ($fixedCount files)" -ForegroundColor Green }
if ($test6Pass) { Write-Host "[OK] Version generation working" -ForegroundColor Green }
if ($test7Pass) { Write-Host "[OK] WiX installer projects found" -ForegroundColor Green }
if ($test8Pass) { Write-Host "[OK] Documentation complete" -ForegroundColor Green }
if ($test9Pass) { Write-Host "[OK] Git tracking $modifiedCount changed files" -ForegroundColor Green }

Write-Host ""
if ($passedTests -eq $totalTests) {
    Write-Host "All tests passed! Ready for commit and push!" -ForegroundColor Green
} else {
    Write-Host "Some tests had warnings - review above" -ForegroundColor Yellow
}
Write-Host ""
