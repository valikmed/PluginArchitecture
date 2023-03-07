using System;
using ProceedPlugin.Sdk;

namespace PoceedPlugin
{
    public class ProceedPlugin : IPlugin
    {
        public string Title => "Plugin for test";

        public string Description => "Hello first extention/plugin!";

        public void DoSomething()
        {
            Console.WriteLine(Title + Description);
        }
    }
}

