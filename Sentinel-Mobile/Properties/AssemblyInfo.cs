using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Resources;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Sentinel Mobile")]
[assembly: AssemblyDescription("Client mobile pour le l'api du client web Sentinel")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("SOVAC")]
[assembly: AssemblyProduct("Sentinel_Mobile")]
[assembly: AssemblyCopyright("Copyright © SOVAC 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c9d618fd-6047-415f-9a62-4c48087fb254")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("0.0.0.1")]

// Below attribute is to suppress FxCop warning "CA2232 : Microsoft.Usage : Add STAThreadAttribute to assembly"
// as Device app does not support STA thread.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")]

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MobileTest")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Sentinel-Mobile-Test")]
[assembly: NeutralResourcesLanguageAttribute("fr")]
