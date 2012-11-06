
namespace HelloWorld.Win.Tests
{
  using System;
  using HelloWorld.Core;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  class MainViewMock : IMainView
  {
    public void SetupView(MainViewPresenter presenter)
    {
      // nop.
    }
  }

  class MessageManagerMock : IMessageManager
  {
    public string GetMessage(string value)
    {
      return string.Format("MOCK {0}", value);
    }
  }

  [TestClass]
  public class MainViewPresenterTest
  {
    [TestMethod]
    public void Test_Setup_Success()
    {
      // Arrange
      var presenter = new MainViewPresenter(new MainViewMock(), new MessageManagerMock());

      // Arrange-Assert
      Assert.IsNull(presenter.Model.Title);
      Assert.IsNull(presenter.Model.Name);
      Assert.IsNull(presenter.Model.Message);

      // Act
      presenter.Setup();

      // Assert
      Assert.IsNotNull(presenter.Model.Title);
      Assert.AreEqual<string>(string.Empty, presenter.Model.Name);
      Assert.AreEqual<string>(string.Empty, presenter.Model.Message);
    }

    [TestMethod]
    public void Test_Title_AfterSetup()
    {
      // Arrange
      var presenter = new MainViewPresenter(new MainViewMock(), new MessageManagerMock());

      // Act
      presenter.Setup();

      // Assert
      Assert.AreEqual<string>("Hello World", presenter.Model.Title);
    }

    [TestMethod]
    public void Test_ButtonClick_Success()
    {
      // Arrange
      var presenter = new MainViewPresenter(new MainViewMock(), new MessageManagerMock());
      
      // Act
      presenter.Setup();
      presenter.Model.Name = "devlights";
      presenter.ButtonClicked();

      // Assert
      Assert.AreEqual<string>("MOCK devlights", presenter.Model.Message);
    }
  }
}
