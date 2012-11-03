
namespace HelloWorld.Core
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  
  public class HelloWorldMessageManager : IMessageManager
  {
    public string GetMessage(string value)
    {
      if (string.IsNullOrEmpty(value))
      {
        return string.Empty;
      }

      return string.Format("Hello World {0}!", value); 
    }
  }
}
