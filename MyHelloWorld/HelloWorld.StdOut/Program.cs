using Ninject.Parameters;

namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using Ninject;

  using HelloWorld.Core;
  
  class Program
  {
    static void Main(string[] args)
    {
      const string THE_NAME = "devlights";

      var kernel = new StandardKernel(new HelloWorldModule());
      var manager = kernel.Get<IMessageManager>(new ConstructorArgument("name", THE_NAME));

      Console.WriteLine(manager.GetMessage());
    }
  }
}
