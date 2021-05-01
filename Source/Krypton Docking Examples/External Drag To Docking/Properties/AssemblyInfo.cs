// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0  www.ComponentFactory.com
//
// *****************************************************************************

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

[assembly: AssemblyVersion("5.500.603.0")]
[assembly: AssemblyFileVersion("5.500.603.0")]
[assembly: AssemblyInformationalVersion("5.500.603.0")]
[assembly: AssemblyCopyright("© Component Factory Pty Ltd, 2006 - 2016. All rights reserved.")]
[assembly: AssemblyProduct("External Drag To Docking")]
[assembly: AssemblyDefaultAlias("ExternalDragToDocking.dll")]
[assembly: AssemblyTitle("External Drag To Docking")]
[assembly: AssemblyCompany("Component Factory")]
[assembly: AssemblyDescription("External Drag To Docking")]
[assembly: AssemblyConfiguration("Production")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: StringFreezing]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers()]
[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: Dependency("Krypton.Toolkit", LoadHint.Always)]
[assembly: Dependency(".Navigator", LoadHint.Always)]
[assembly: Dependency(".Workspace", LoadHint.Always)]
[assembly: Dependency(".Docking", LoadHint.Always)]
