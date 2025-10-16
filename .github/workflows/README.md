# GitHub Actions Workflows

This directory contains GitHub Actions workflows for automated building and releasing of the Krypton Standard Toolkit Demos.

## Version Format

All installer versions follow the format: **`MAJOR.YY.MM.BUILD`**

- **MAJOR** = Major version (e.g., `100`)
- **YY** = Last two digits of the year (e.g., `25` for 2025)
- **MM** = Month (e.g., `10` for October)
- **BUILD** = Build number (from tag or day of year)

**Examples:**
- Release tag `v100.25.10.289` → Version `100.25.10.289`
- Nightly build on Oct 16, 2025 → Version `100.25.10.289` (day 289)

**Installer naming:**
- Release: `Samples.v100.25.10.289.Net48.msi`
- Nightly: `Samples.v100.25.10.289-beta.Net48.msi`

---

## Workflows

### 🔨 `build.yml` - Continuous Integration

**Triggers:**
- Push to any branch
- Pull requests to any branch
- Manual workflow dispatch

**What it does:**
1. Builds all demo solutions in both Debug and Release configurations
2. Targets multiple .NET versions (net48, net8.0, net9.0)
3. Uploads build artifacts (Release configuration only)
4. Uploads build logs on failure for debugging

**Solutions built:**
- Krypton Explorer
- Krypton Docking Examples
- Krypton Navigator Examples
- Krypton Ribbon Examples
- Krypton Toolkit Examples
- Krypton Workspace Examples

**Artifacts:**
- `build-output-Release` - Compiled demo applications (EXE/DLL files)
- `build-logs-*` - Build logs (only on failure, 14-day retention)

---

### 🚀 `release.yml` - Release and Installer Creation

**Triggers:**
- Push to `master` branch
- Push of version tags (e.g., `v1.0.0`)
- Manual workflow dispatch

**What it does:**
1. Builds all demo solutions in Release configuration
2. Verifies build outputs for all .NET versions
3. Installs WiX Toolset 4.0.6
4. Builds MSI installers for:
   - .NET Framework 4.8
   - .NET 8.0 Windows
   - .NET 9.0 Windows
   - .NET 10.0 Windows
5. Creates a GitHub Release with:
   - All MSI installers attached
   - Comprehensive release notes
   - Version tagging (from git tag or nightly build)

**Artifacts:**
- `release-binaries` - All compiled demo applications (30-day retention)
- `installers` - MSI installer packages (90-day retention)

**GitHub Release:**
- Automatically created when pushing to `master` or when pushing a version tag
- Includes all MSI installers
- Pre-release flag for nightly builds
- Full changelog and installation instructions

---

## Requirements

### GitHub Actions Runner
- **OS:** Windows (windows-latest)
- **Pre-installed:**
  - MSBuild (via `microsoft/setup-msbuild@v2`)
  - NuGet CLI
  - Visual Studio 2022 components

### .NET SDKs
- .NET 8.0
- .NET 9.0
- .NET Framework 4.8 (pre-installed on Windows runners)

### WiX Toolset
- WiX 4.0.6 (installed via dotnet tool during release workflow)

---

## Workflow Permissions

### `build.yml`
- **Permissions:** Default (read repository)
- **Secrets:** None required

### `release.yml`
- **Permissions:** `contents: write` (to create releases)
- **Secrets:** `GITHUB_TOKEN` (automatically provided)

---

## Usage

### Running Builds Manually

1. Navigate to **Actions** tab in GitHub
2. Select **Build** workflow
3. Click **Run workflow**
4. Choose the branch to build
5. Click **Run workflow** button

### Creating a Release

**Option 1: Push to master branch**
```bash
git checkout master
git merge your-feature-branch
git push origin master
```
This creates a "nightly build" release with automatic versioning (e.g., `v100.25.10.289-beta`).

**Option 2: Create and push a version tag (Recommended)**
```bash
# Tag format: vMAJOR.YY.MM.BUILD
# Example for October 16, 2025, build 289:
git tag -a v100.25.10.289 -m "Release version 100.25.10.289"
git push origin v100.25.10.289
```
This creates an official release with the specified version number.

**Version Guidelines:**
- Use the format `vMAJOR.YY.MM.BUILD` (e.g., `v100.25.10.289`)
- **MAJOR**: Current major version (currently `100`)
- **YY**: Last two digits of the year (e.g., `25` for 2025)
- **MM**: Month number (e.g., `10` for October)
- **BUILD**: Increment this for each release in the same month

**Option 3: Manual workflow dispatch**
1. Navigate to **Actions** tab in GitHub
2. Select **Release** workflow
3. Click **Run workflow**
4. Choose the branch
5. Toggle "Create GitHub Release" option
6. Click **Run workflow** button

---

## Build Matrix

### CI Build (`build.yml`)

| Configuration | .NET Versions | Artifact |
|--------------|---------------|----------|
| Debug | net48, net8.0, net9.0 | ❌ Not uploaded |
| Release | net48, net8.0, net9.0 | ✅ Uploaded (7 days) |

### Release Build (`release.yml`)

| Configuration | .NET Versions | Installers | Artifact |
|--------------|---------------|-----------|----------|
| Release | net48, net8.0, net9.0 | ✅ All versions | ✅ Uploaded (90 days) |

---

## Troubleshooting

### Build Failures

**Check build logs:**
1. Go to the failed workflow run
2. Expand the failed step
3. Review error messages
4. Download `build-logs-*` artifact if available

**Common issues:**
- Missing NuGet packages → Restore step may have failed
- Compilation errors → Check source code compatibility
- MSBuild not found → Runner image issue (rare)

### Installer Build Failures

**WiX-related issues:**
- Ensure demo binaries are built successfully first
- Check that all required .NET versions are built
- Verify WiX package restoration worked
- Check WiX project file paths in `WixInstaller.net*/` directories

**Path issues:**
- Installer projects expect binaries in specific paths:
  - `Binaries/Krypton Demos/Release/net48`
  - `Binaries/Krypton Demos/Release/net8.0-windows`
  - `Binaries/Krypton Demos/Release/net9.0-windows`

### Release Creation Failures

**Permission denied:**
- Verify `contents: write` permission is granted
- Check repository settings → Actions → General → Workflow permissions

**No installers uploaded:**
- Check that WiX build steps completed successfully
- Verify MSI files exist in expected locations
- Review "List installer outputs" step

---

## Maintenance

### Updating .NET Versions

When adding support for new .NET versions:

1. Update `build.yml`:
   - Add new .NET SDK setup step
   - Verify solution files support the new version

2. Update `release.yml`:
   - Add new .NET SDK setup step
   - Add new WiX installer build step
   - Update "Verify build outputs" step with new path
   - Update release notes body

3. Ensure WiX installer projects exist for the new version in `Source/WixInstaller/`

### Updating WiX Version

To upgrade WiX Toolset:

1. Update `release.yml`:
   - Change version in "Setup WiX Toolset" step
   
2. Update WiX project files:
   - Update `Sdk.props` and `Sdk.targets` versions
   - Update package references in `packages.config`

### Changing Release Behavior

**To disable automatic releases on master:**
- Remove `master` from `release.yml` triggers
- Use only tag-based releases or manual dispatch

**To change artifact retention:**
- Modify `retention-days` in upload-artifact steps
- Default: 7 days (CI), 90 days (releases)

---

## Best Practices

1. **Always test locally first**
   - Run `build-all.cmd Release all on` before pushing
   - Verify all solutions build successfully

2. **Use semantic versioning for tags**
   - Format: `vMAJOR.MINOR.PATCH` (e.g., `v1.2.3`)
   - Prefix with `v` for consistency

3. **Review build artifacts**
   - Download and test installers before promoting releases
   - Verify all .NET versions are included

4. **Monitor workflow runs**
   - Check Actions tab regularly for failures
   - Fix issues promptly to maintain CI health

---

## Support

For issues with workflows:
1. Check workflow run logs
2. Review this documentation
3. Open an issue in the repository with:
   - Workflow name
   - Run ID/URL
   - Error messages
   - Steps to reproduce

---

**Last Updated:** October 16, 2025  
**Workflows Version:** 1.0

