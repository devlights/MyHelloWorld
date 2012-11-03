
namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using HelloWorld.Core;
  
  class Program
  {
    static void Main(string[] args)
    {
      const string THE_NAME = "devlights";

      var manager = new HelloWorldMessageManager(THE_NAME);
      Console.WriteLine(manager.GetMessage());
    }
  }
}
