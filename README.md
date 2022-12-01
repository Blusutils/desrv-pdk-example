# DESrv example plugin (PDK)
Example plugin for DESrv using PDK.

* [**How to use this temaplate**](#creating-plugin-from-a-scratch)
* [**How to create extension from a scratch**](#template-usage)

## Prerequesties

* [.NET SDK 6.0](https://dotnet.microsoft.com/en-us/download)
* [DESrv](https://github.com/Blusutils/DESrv/releases/latest)
* Visual Studio 2022 (17) (optioal, but recommended)

## Template usage
0. Use this template repo through GitHub (OPTIONAL AND NOT REQUIRED)
1. Clone template:
```powershell
# replace to link to your fork if you made it
git clone https://github.com/Blusutils/desrv-pdk-example.git
```
2. Replace reference to PDK from local DLL to downloaded with DESrv
3. Edit project file, namecpace, class names, values of ID and so on in `des-pdk-example/Class1.cs`
4. Write your plugin
5. Build project from VS or CLI:
```powershell
dotnet build
```
6. Put out extension to `extensions` folder in DESrv directory.

## Creating plugin from a scratch

1. Create `Class Library` project from VS or using CLI:
```powershell
mkdir MyPlugin && cd MyPlugin
dotnet new classlib
```

2. Add reference to PDK:
```powershell
dotnet add reference "./path/to/pdk/in/desrv/PDK.dll"
```

3. (optional) Install DESCEndLib:
```powershell
Install-Package DESCEndLib
```

4. Paste following code to .cs file (replace namecpace, class names and values of ID and so on):
```csharp
using DESrv.PDK;
namespace DESPDKExamples1 {
    [PDKExtension]
    public class ExamplePlugin : AbstractPDKExtension {
        // Metadata of extension
        public override ExtensionMetadata Metadata { get; set; } = new ExtensionMetadata() {
            // ID of extension. It mustn't contain spaces and special symbols (for example dots)
            ID = "ExamplePlugin",
            // Type of extension: 1 - plugin, 2 - addon, 3 - random provider
            ExtType = 1,
            // Readable name of extension
            Name = "Example Plugin",
            // Description for extension
            Description = "Just an example",
            // Author of extension
            Author = "Blusutils",
            // Version of extension
            Version = "0.1.0",
            // Version of DESrv what this extension supports
            DESVersion= "1.3.0",
            // Array of dependencies for extension
            //Dependencies = new string[] {},
            // ID of extension to which this extension refers (for addons)
            //Reference = ""
        };
        // Main method
        public override void Entrypoint() { Console.WriteLine("Hello DESrv!"); }
        // Event what calls when extension loads
        public override void Load() { }
        // Event what calls when extension unloads
        public override void Unload() { }
        // Load addon to this extension (for plugins)
        public override void LoadSubExtension(AbstractPDKExtension extension) { extension.Load(); }
    }
}
```

    Don't forget to implement your plugin features too.

5. Build project from VS or CLI:
```powershell
dotnet build
```

6. Put out extension to `extensions` folder in DESrv directory.
