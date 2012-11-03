
namespace HelloWorld.StdOut
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  using HelloWorld.Core;
  
  class Program
  {
    static void Main(string[] args)
    {
      const string NAME = "devlights";

      var manager = new HelloWorldMessageManager(NAME);
      Console.WriteLine(manager.GetMessage());
    }
  }
}
