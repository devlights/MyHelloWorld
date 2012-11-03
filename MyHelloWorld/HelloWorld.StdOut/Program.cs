
namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using Ninject;
  using Ninject.Parameters;

  using HelloWorld.Core;
  using HelloWorld.Core.NinjectModules;
  
  class Program
  {
    static void Main(string[] args)
    {
      var kernel = new StandardKernel(new HelloWorldModule());
      var manager = kernel.Get<IMessageManager>();

      Console.WriteLine(manager.GetMessage("devlights"));
    }
  }
}
