
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  using System.Windows.Forms;

  using Ninject;

  using HelloWorld.Core;
  using HelloWorld.Core.NinjectModules;
  using HelloWorld.Win.NinjectModules;

  static class Program
  {
    [STAThread]
    static void Main()
    {
      SetupKernel();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(DIHelper.Kernel.Get<MainView>());
    }

    static void SetupKernel()
    {
      var kernel = new StandardKernel(new HelloWorldCoreModule(), new HelloWorldWinModule());
      DIHelper.RegistKernel(kernel);
    }
  }
}
