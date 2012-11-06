
namespace HelloWorld.Core
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  
  using Ninject;

  public class DIHelper
  {
    static IKernel _Kernel;

    public static void RegistKernel(IKernel kernel)
    {
      if (kernel == null)
      {
        throw new ArgumentNullException("kernel");
      }

      if (_Kernel != null)
      {
        throw new InvalidOperationException("kernel is already registed.");
      }

      _Kernel = kernel;
    }

    public static void Unregist()
    {
      if (_Kernel == null)
      {
        return;
      }

      _Kernel = null;
    }

    public static IKernel Kernel
    {
      get
      {
        if (_Kernel == null)
        {
          throw new InvalidOperationException("kernel is not registed.");
        }

        return _Kernel;
      }
    }
  }
}
