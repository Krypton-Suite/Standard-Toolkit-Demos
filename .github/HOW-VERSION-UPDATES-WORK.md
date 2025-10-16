# How Dynamic WiX Version Updates Work

This document explains how the GitHub Actions `release.yml` workflow automatically updates WiX installer versions.

## Overview

The workflow dynamically updates version numbers in WiX installer files **before** building them, ensuring that:
- MSI packages have the correct version metadata
- Installer file names reflect the actual release version
- No manual version updates are needed

## Version Format

**Format:** `MAJOR.YY.MM.BUILD`

- **MAJOR**: Major version (e.g., `100`)
- **YY**: Year (last 2 digits, e.g., `25` for 2025)
- **MM**: Month (e.g., `10` for October)
- **BUILD**: Build number (from git tag or day of year)

**Example:** `100.25.10.289`

---

## Step-by-Step Process

### 1. Version Generation

The workflow first generates the version number:

```yaml
- name: Generate version number
  id: get_version
```

**For Tagged Releases:**
```bash
git tag v100.25.10.289
```
→ Version: `100.25.10.289` (extracted from tag)

**For Nightly Builds:**
```bash
git push origin master
```
→ Version: `100.25.10.289` (auto-generated using day of year)
→ Suffix: `-beta`

---

### 2. Update Product.wxs Files

Updates the version definition in each WiX Product file:

**Files Updated:**
- `Source/WixInstaller/WixInstaller.net48/Product.wxs`
- `Source/WixInstaller/WixInstaller.net80/Product.wxs`
- `Source/WixInstaller/WixInstaller.net90/Product.wxs`
- `Source/WixInstaller/WixInstaller.net100/Product.wxs`

**What Changes:**
```xml
<!-- Before -->
<?define Version = "100.24.12.344" ?>

<!-- After -->
<?define Version = "100.25.10.289" ?>
```

**PowerShell Code:**
```powershell
$content = Get-Content $file -Raw
$content = $content -replace '(<\?define Version = ")[^"]+(")', "`${1}$version`$2"
Set-Content $file -Value $content -NoNewline
```

---

### 3. Update .wixproj OutputName

Updates the MSI output filename in each project file:

**Files Updated:**
- `Source/WixInstaller/WixInstaller.net48/WixInstaller.net48.wixproj`
- `Source/WixInstaller/WixInstaller.net80/WixInstaller.net80.wixproj`
- `Source/WixInstaller/WixInstaller.net90/WixInstaller.net90.wixproj`
- `Source/WixInstaller/WixInstaller.net100/WixInstaller.net100.wixproj`

**What Changes:**

*Release Build:*
```xml
<!-- Before -->
<OutputName>Samples.v100.24.12.344-beta.Net48</OutputName>

<!-- After -->
<OutputName>Samples.v100.25.10.289.Net48</OutputName>
```

*Nightly Build:*
```xml
<!-- Before -->
<OutputName>Samples.v100.24.12.344-beta.Net48</OutputName>

<!-- After -->
<OutputName>Samples.v100.25.10.289-beta.Net48</OutputName>
```

**PowerShell Code:**
```powershell
$newOutputName = "Samples.v$version$prereleaseSuffix.$target"
$content = $content -replace '(<OutputName>)[^<]+(</OutputName>)', "`${1}$newOutputName`$2"
Set-Content $file -Value $content -NoNewline
```

---

### 4. Build WiX Installers

After updates, MSBuild creates the installers with the new versions:

```bash
msbuild WixInstaller.net48.wixproj /p:Configuration=Release /p:Platform=x86
```

**Output Files:**

*Release Build:*
- `Samples.v100.25.10.289.Net48.msi`
- `Samples.v100.25.10.289.Net80.msi`
- `Samples.v100.25.10.289.Net90.msi`
- `Samples.v100.25.10.289.Net100.msi`

*Nightly Build:*
- `Samples.v100.25.10.289-beta.Net48.msi`
- `Samples.v100.25.10.289-beta.Net80.msi`
- `Samples.v100.25.10.289-beta.Net90.msi`
- `Samples.v100.25.10.289-beta.Net100.msi`

---

## Real-World Example

### Scenario: Creating Release v100.25.10.289

**Step 1:** Create and push tag
```bash
git tag -a v100.25.10.289 -m "Release version 100.25.10.289"
git push origin v100.25.10.289
```

**Step 2:** GitHub Actions workflow triggers and:

1. Extracts version: `100.25.10.289`
2. Updates all `Product.wxs` files with version `100.25.10.289`
3. Updates all `.wixproj` files with `Samples.v100.25.10.289.Net*`
4. Builds all 4 MSI installers
5. Creates GitHub Release with installers attached

**Step 3:** Result

GitHub Release contains:
```
✓ Samples.v100.25.10.289.Net48.msi
✓ Samples.v100.25.10.289.Net80.msi
✓ Samples.v100.25.10.289.Net90.msi
✓ Samples.v100.25.10.289.Net100.msi
```

---

## Benefits

✅ **No Manual Updates** - Version is set automatically from git tags  
✅ **Consistent Naming** - All installers follow the same version format  
✅ **Accurate Metadata** - MSI internal version matches filename  
✅ **Traceable** - Easy to identify which tag created which installer  
✅ **Automated** - Works for both releases and nightly builds

---

## Workflow Location

The dynamic version update is implemented in:
```
.github/workflows/release.yml
```

**Relevant Steps:**
1. `Generate version number` (lines 118-173)
2. `Update WiX installer versions` (lines 175-227)
3. Build WiX Installer steps (lines 238-272)

---

## Testing Locally

To verify the version update logic works correctly:

```bash
# View current versions
grep "define Version" Source/WixInstaller/*/Product.wxs
grep "<OutputName>" Source/WixInstaller/*/*.wixproj

# After running the workflow, the versions will be updated automatically
```

---

## Notes

- The version update happens **before** building, so the changes are temporary (not committed to git)
- Each workflow run generates fresh version numbers based on the trigger (tag or date)
- The `Product.wxs` version is used by Windows Installer for upgrade logic
- The `.wixproj` OutputName determines the final MSI filename

---

**Last Updated:** October 16, 2025  
**Version Format:** MAJOR.YY.MM.BUILD (e.g., 100.25.10.289)

