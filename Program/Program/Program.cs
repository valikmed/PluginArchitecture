using System.Reflection;
using ProceedPlugin.Sdk;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            _plugins = ReadExtentions();
            Console.WriteLine($"{_plugins.Count} plugin(s) found");

            foreach (var plugin in _plugins)
            {
                Console.WriteLine($"{plugin.Title}|{plugin.Description}");
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();

        }

        static List<IPlugin> _plugins = null;

        static List<IPlugin> ReadExtentions()
        {
            // 1- Read the dll files from the extention folder
            var files = Directory.GetFiles("extentions", "*dll");

            var pluginsLists = new List<IPlugin>();


            //2- Read assmebly from files

            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(Path.Combine(Directory.GetCurrentDirectory(), file));

                //3 - Extract all the types that implements IPlugin
                var pluginTypes = assembly.GetTypes().Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface).ToArray();

                foreach (var pluginType in pluginTypes)
                {
                    //4 - Create an instans for the executed type
                    var pluginInstance = Activator.CreateInstance(pluginType) as IPlugin;

                    pluginsLists.Add(pluginInstance);
                }
            }

            return pluginsLists;
        }

    }
}