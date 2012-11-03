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
      var manager = new HelloWorldMessageManager("devlights");
      Console.WriteLine(manager.GetMessage());
    }
  }
}
