#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion

using System;

using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion("5.550.0")]
[assembly: AssemblyFileVersion("5.550.0")]
[assembly: AssemblyInformationalVersion("5.550.0")]
[assembly: AssemblyCopyright("© Component Factory Pty Ltd, 2006 - 2016. All rights reserved.")]
[assembly: AssemblyProduct("Cell Maximize + Restore")]
[assembly: AssemblyDefaultAlias("CellMaximizeAndRestore.dll")]
[assembly: AssemblyTitle("Cell Maximize + Restore")]
[assembly: AssemblyCompany("Component Factory")]
[assembly: AssemblyDescription("Cell Maximize + Restore")]
[assembly: AssemblyConfiguration("Production")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: StringFreezing]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: Dependency("Krypton.Toolkit", LoadHint.Always)]
[assembly: Dependency("Krypton.Navigator", LoadHint.Always)]
[assembly: Dependency("Krypton.Workspace", LoadHint.Always)]
