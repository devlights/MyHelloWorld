﻿
namespace HelloWorld.Core.NinjectModules
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  using Ninject.Modules;

  public class HelloWorldCoreModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IMessageManager>().To<HelloWorldMessageManager>();
    }
  }
}
