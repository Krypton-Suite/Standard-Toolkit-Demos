# NuGet Package Management

This document explains how NuGet packages are managed in the CI/CD workflows.

## Packages Used

All demo projects use **Canary (beta)** versions of the Krypton Standard Toolkit from NuGet.org:

| Package | Version | Type |
|---------|---------|------|
| `Krypton.Toolkit.Canary` | 100.25.8.234-beta | Pre-release |
| `Krypton.Navigator.Canary` | 100.25.8.234-beta | Pre-release |
| `Krypton.Ribbon.Canary` | 100.25.8.234-beta | Pre-release |
| `Krypton.Docking.Canary` | 100.25.8.234-beta | Pre-release |
| `Krypton.Workspace.Canary` | 100.25.8.234-beta | Pre-release |

**Source:** [NuGet.org](https://www.nuget.org/packages?q=krypton+canary)

---

## How It Works

### Project File Conditional Logic

Each `.csproj` file uses conditional logic to determine whether to use NuGet packages or project references:

```xml
<Choose>
    <When Condition="'$(SolutionName.Contains('Nuget'))'">
        <!-- Use NuGet packages for "-Nuget.sln" solutions -->
        <ItemGroup>
            <PackageReference Include="Krypton.Toolkit.Canary" Version="100.25.8.234-beta" />
        </ItemGroup>
    </When>
    <Otherwise>
        <!-- Use project references for "-Dev.sln" solutions -->
        <ItemGroup>
            <ProjectReference Include="..\..\..\..\Standard-Toolkit\Source\..." />
        </ItemGroup>
    </Otherwise>
</Choose>
```

**Key Points:**
- ✅ Solutions with "Nuget" in the name → Use NuGet packages
- ✅ Solutions with "Dev" in the name → Use project references (requires sibling repo)
- ✅ GitHub Actions workflows only build "Nuget" solutions

---

## Workflow NuGet Restore

Both `build.yml` and `release.yml` workflows include explicit NuGet restore steps:

### Step 1: Configure NuGet

```yaml
- name: Configure NuGet
  run: |
    # List configured sources
    nuget sources list
    
    # Ensure nuget.org is available (for beta packages)
    nuget sources Add -Name "nuget.org" -Source "https://api.nuget.org/v3/index.json"
```

### Step 2: Restore Packages

```yaml
- name: Restore NuGet packages
  run: |
    nuget restore "Solution.sln" -NonInteractive
```

### Step 3: Build with Restore

```yaml
- name: Build solution
  run: msbuild "Solution.sln" /restore /p:Configuration=Release
```

**Note:** MSBuild's `/restore` flag provides additional restore safety during build.

---

## Why Pre-release/Beta Packages?

The "Canary" packages are:
- **Latest development versions** with newest features
- **Pre-release/beta** status on NuGet.org
- **Regularly updated** to track main toolkit development
- **Suitable for demos** to showcase latest capabilities

---

## Updating Package Versions

To update the NuGet package versions across all projects:

### Option 1: Manual Update (Single Project)

Edit the `.csproj` file:

```xml
<PackageReference Include="Krypton.Toolkit.Canary" Version="100.25.8.234-beta" />
<!-- Change to: -->
<PackageReference Include="Krypton.Toolkit.Canary" Version="100.26.1.100-beta" />
```

### Option 2: Bulk Update (All Projects)

Use PowerShell script:

```powershell
$oldVersion = "100.25.8.234-beta"
$newVersion = "100.26.1.100-beta"

$files = Get-ChildItem -Path "Source" -Recurse -Filter "*.csproj"

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    $content = $content -replace $oldVersion, $newVersion
    Set-Content -Path $file.FullName -Value $content -NoNewline
}

Write-Host "Updated $(($files).Count) project files to version $newVersion"
```

### Option 3: Central Package Management (Future)

Consider using `Directory.Packages.props` for centralized version management:

```xml
<Project>
  <PropertyGroup>
    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
  </PropertyGroup>
  <ItemGroup>
    <PackageVersion Include="Krypton.Toolkit.Canary" Version="100.25.8.234-beta" />
    <PackageVersion Include="Krypton.Navigator.Canary" Version="100.25.8.234-beta" />
    <!-- etc. -->
  </ItemGroup>
</Project>
```

---

## Troubleshooting

### Issue: Package Not Found

**Error:**
```
Unable to find package 'Krypton.Toolkit.Canary' version '100.25.8.234-beta'
```

**Solutions:**
1. Verify package exists on NuGet.org:
   ```bash
   nuget list Krypton.Toolkit.Canary -AllVersions -PreRelease
   ```

2. Check NuGet sources:
   ```bash
   nuget sources list
   ```

3. Clear NuGet cache:
   ```bash
   nuget locals all -clear
   dotnet nuget locals all --clear
   ```

### Issue: Package Restore Failed

**Solutions:**
1. Run restore with verbose logging:
   ```bash
   nuget restore Solution.sln -Verbosity detailed
   ```

2. Check internet connectivity to nuget.org

3. Verify `nuget.config` (if present) doesn't block nuget.org

### Issue: Wrong Package Version Used

**Solutions:**
1. Delete `bin` and `obj` folders:
   ```bash
   Get-ChildItem -Recurse -Include bin,obj | Remove-Item -Recurse -Force
   ```

2. Restore packages fresh:
   ```bash
   nuget restore Solution.sln -Force
   ```

---

## Local Development

### Using NuGet Packages Locally

1. Open a "Nuget" solution:
   ```
   Krypton Explorer 2022 - Nuget.sln
   ```

2. Restore packages in Visual Studio:
   - Right-click solution → Restore NuGet Packages
   - Or build (automatic restore enabled)

3. Or use command line:
   ```bash
   nuget restore "Solution - Nuget.sln"
   msbuild "Solution - Nuget.sln" /restore /p:Configuration=Debug
   ```

### Using Dev Project References Locally

1. Clone both repositories side-by-side:
   ```
   /Development/Krypton/
   ├── Standard-Toolkit/
   └── Standard-Toolkit-Demos/
   ```

2. Open a "Dev" solution:
   ```
   Krypton Explorer 2022 - Dev.sln
   ```

3. Build normally (no NuGet restore needed)

---

## GitHub Actions Specifics

### NuGet CLI Pre-installed

GitHub's `windows-latest` runners include:
- ✅ NuGet CLI (latest version)
- ✅ MSBuild 17.x (VS 2022)
- ✅ .NET SDK 8.0+ (via setup-dotnet action)
- ✅ Pre-configured nuget.org source

### No Authentication Required

- ✅ Public packages from nuget.org require no authentication
- ✅ Pre-release/beta packages are accessible without API keys
- ✅ Workflows run successfully without secrets

---

## Best Practices

1. **Always restore before building** in CI/CD
2. **Use `/restore` flag** with MSBuild for safety
3. **Pin package versions** (avoid floating versions like `*` or `1.0.*`)
4. **Test locally first** before pushing to CI
5. **Clear caches** when updating package versions
6. **Document version requirements** in README

---

**Last Updated:** October 16, 2025  
**Current Package Version:** 100.25.8.234-beta  
**Package Source:** NuGet.org

