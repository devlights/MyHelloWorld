
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using Ninject;

  using HelloWorld.Core;
  using HelloWorld.Core.NinjectModules;

  public class MainViewPresenter
  {
    IMainView _view;
    MainViewModel _model;
    IMessageManager _manager;

    public MainViewPresenter(IMainView view)
    {
      _view = view;
      _model = new MainViewModel();
      _manager = new StandardKernel(new HelloWorldModule()).Get<IMessageManager>();
    }

    public MainViewModel Model
    {
      get
      {
        return _model;
      }
    }

    public void Setup()
    {
      _model.Title = "Hello World";
      _model.Name = string.Empty;
      _model.Message = string.Empty;

      _view.SetupView(this);
    }

    public void ButtonClicked(object sender, EventArgs e)
    {
      _model.Message = _manager.GetMessage(_model.Name);
    }
  }
}
