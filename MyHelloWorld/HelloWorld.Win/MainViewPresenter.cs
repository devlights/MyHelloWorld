
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using HelloWorld.Core;

  public class MainViewPresenter
  {
    IMainView       _view;
    MainViewModel   _model;
    IMessageManager _manager;

    public MainViewPresenter(IMainView view, IMessageManager manager)
    {
      _view    = view;
      _model   = new MainViewModel();
      _manager = manager;
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
      _model.Title   = "Hello World";
      _model.Name    = string.Empty;
      _model.Message = string.Empty;

      _view.SetupView(this);
    }

    public void ButtonClicked()
    {
      _model.Message = _manager.GetMessage(_model.Name);
    }
  }
}
