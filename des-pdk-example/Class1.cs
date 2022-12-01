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
        public override void Entrypoint() {
            Console.WriteLine("Hello DESrv!");
        }
        // Event what calls when extension loads
        public override void Load() {

        }
        // Event what calls when extension unloads
        public override void Unload() {

        }
        // Load addon to this extension (for plugins)
        public override void LoadSubExtension(AbstractPDKExtension extension) => extension.Load();
    }
}