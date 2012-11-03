using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld.Core;

namespace HelloWorld.StdOut
{
  class Program
  {
    static void Main(string[] args)
    {
      const string name = "devlights";

      var manager = new HelloWorldMessageManager(name);
      Console.WriteLine(manager.GetMessage());
    }
  }
}
