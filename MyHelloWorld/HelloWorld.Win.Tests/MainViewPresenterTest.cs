
namespace HelloWorld.Win.Tests
{
  using System;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  class MainViewMock : IMainView
  {
    public void SetupView(MainViewPresenter presenter)
    {
      // nop.
    }
  }

  [TestClass]
  public class MainViewPresenterTest
  {
    [TestMethod]
    public void Test_Setup_Success()
    {
      // Arrange
      var presenter = new MainViewPresenter(new MainViewMock());

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
      var presenter = new MainViewPresenter(new MainViewMock());

      // Act
      presenter.Setup();

      // Assert
      Assert.AreEqual<string>("Hello World", presenter.Model.Title);
    }

    [TestMethod]
    public void Test_ButtonClick_Success()
    {
      // Arrange
      var presenter = new MainViewPresenter(new MainViewMock());
      
      // Act
      presenter.Setup();
      presenter.Model.Name = "devlights";
      presenter.ButtonClicked(new object(), EventArgs.Empty);

      // Assert
      Assert.AreEqual<string>("Hello World devlights!", presenter.Model.Message);
    }
  }
}
