
namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using HelloWorld.Core;
  using HelloWorld.Core.NinjectModules;

  using Ninject;
  
  class Program
  {
    static void Main()
    {
      var kernel  = new StandardKernel(new HelloWorldModule());
      var manager = kernel.Get<IMessageManager>();

      Console.WriteLine(manager.GetMessage("devlights"));
    }
  }
}
