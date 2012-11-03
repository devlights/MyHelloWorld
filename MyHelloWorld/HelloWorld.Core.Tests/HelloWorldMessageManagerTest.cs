
namespace HelloWorld.Core.Tests
{
  using System;
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  
  [TestClass]
  public class HelloWorldMessageManagerTest
  {
    [TestMethod]
    public void Test_GetMessage_Success()
    {
      // Arrange.
      var manager = new HelloWorldMessageManager();

      // Act.
      var result  = manager.GetMessage("test");

      // Assert.
      Assert.AreEqual<string>("Hello World test!", result);
    }

    [TestMethod]
    public void Test_GetMessage_Empty()
    {
      // Arrange.
      var manager = new HelloWorldMessageManager();

      // Act.
      var result = manager.GetMessage(string.Empty);

      // Assert.
      Assert.AreEqual<string>(string.Empty, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Test_GetMessage_Null()
    {
      // Arrange.
      var manager = new HelloWorldMessageManager();

      // Act.
      // Assert.
      manager.GetMessage(null);
    }

    [TestMethod]
    public void Test_GetMessage_LongName()
    {
      // Arrange.
      var manager = new HelloWorldMessageManager();

      // Act.
      var longName = "longlonglonglonglonglonglonglonglonglonglonglongName";
      var result   = manager.GetMessage(longName);

      // Assert.
      Assert.AreEqual<string>(string.Format("Hello World {0}!", longName), result);
    }
  }
}
