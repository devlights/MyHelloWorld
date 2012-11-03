using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Core.Tests
{
  [TestClass]
  public class HelloWorldMessageManagerTest
  {
    [TestMethod]
    public void Test_GetMessage_Success()
    {
      // Arrange.
      var manager = new HelloWorldMessageManager("test");

      // Act.
      var result  = manager.GetMessage();

      // Assert.
      var expected = "Hello World test!";
      Assert.AreEqual<string>(expected, result);
    }
  }
}
