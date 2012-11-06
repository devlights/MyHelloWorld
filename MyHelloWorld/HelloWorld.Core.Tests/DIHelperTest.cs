using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace HelloWorld.Core.Tests
{
  [TestClass]
  public class DIHelperTest
  {
    [TestCleanup]
    public void Cleanup()
    {
      DIHelper.Unregist();
    }

    [TestMethod]
    public void Test_RegistKernel_Success()
    {
      // Arrange.
      var kernel = new StandardKernel();

      // Act.
      DIHelper.RegistKernel(kernel);

      // Assert.
      Assert.IsNotNull(DIHelper.Kernel);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Test_RegistKernel_Null()
    {
      DIHelper.RegistKernel(null);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Test_RegistKernel_AlreadyRegisted()
    {
      DIHelper.RegistKernel(new StandardKernel());
      DIHelper.RegistKernel(new StandardKernel());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Test_Unregist_Success()
    {
      // Arrange.
      DIHelper.RegistKernel(new StandardKernel());

      // Act.
      DIHelper.Unregist();

      // Assert.
      var kernel = DIHelper.Kernel;
    }

    [TestMethod]
    public void Test_Unregist_RegistClearRegistPattern()
    {
      // Arrange.
      DIHelper.RegistKernel(new StandardKernel());

      // Act.
      DIHelper.Unregist();
      DIHelper.RegistKernel(new StandardKernel());

      // Assert.
      Assert.IsNotNull(DIHelper.Kernel);
    }

    [TestMethod]
    public void Test_Kernel_Success()
    {
      // Arrange.
      var kernel = new StandardKernel();

      // Act.
      DIHelper.RegistKernel(kernel);

      // Assert.
      Assert.IsNotNull(DIHelper.Kernel);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Test_Kernel_Null()
    {
      var kernel = DIHelper.Kernel;
    }
  }
}
