using System;
namespace ProceedPlugin.Sdk
{
	public interface IPlugin
	{
        string Title { get; }

        string Description { get; }

        public void DoSomething();
    }
}

