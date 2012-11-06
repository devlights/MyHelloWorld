using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace HelloWorld.Win.NinjectModules
{
  public class HelloWorldWinModule : NinjectModule
  {
    public override void Load()
    {
      Bind<MainView>().ToSelf();
    }
  }
}
