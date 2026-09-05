# Standard-Toolkit-Demos Installer
- After building the release version of everything then, run this to create the `msi` installer file.

## Requirements
- wix 4.0.6 (Or greater) via nuget (Not 5.x yet !)
- wix visx (`Heatwave`) VS integration installed
- All Toolkit Demos solution built in `Release` (Use the Explorer solution)
  - Remeber to alter the version number in the Explorer Form.cs
  - And the version numbers of the msi outputnames in eachof the installer projects
- A bit of time ;-)
- Push PR and then push msi's with a tagged build the same as the msi version name