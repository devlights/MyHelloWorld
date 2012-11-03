
namespace HelloWorld.Core
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  
  public class HelloWorldMessageManager : IMessageManager
  {
    private readonly string _name;

    public HelloWorldMessageManager(string name)
    {
      _name = name;
    }

    public string GetMessage()
    {
      if (string.IsNullOrEmpty(_name))
      {
        return string.Empty;
      }

      return string.Format("Hello World {0}!", _name); 
    }
  }
}
