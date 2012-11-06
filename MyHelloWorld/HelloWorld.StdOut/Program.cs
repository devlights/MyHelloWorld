
namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using Ninject;

  using HelloWorld.Core;
  using HelloWorld.Core.NinjectModules;
  using HelloWorld.StdOut.NinjectModules;
  
  class Program
  {
    [Inject]
    public IMessageManager Manager { get; set; }

    static void Main()
    {
      SetupKernel();
      DIHelper.Kernel.Get<Program>().Execute();
    }

    internal static void SetupKernel()
    {
      var kernel = new StandardKernel(new HelloWorldCoreModule(), new HelloWorldStdOutModule());
      DIHelper.RegistKernel(kernel);
    }

    public void Execute()
    {
      Console.WriteLine(Manager.GetMessage("devlights"));
    }
  }
}
