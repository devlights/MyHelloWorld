
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Windows.Forms;

  using Ninject;

  using HelloWorld.Core;

  public partial class MainView : Form, IMainView
  {
    MainViewPresenter _presenter;

    [Inject]
    public MainView(IMessageManager manager)
    {
      InitializeComponent();

      if (!DesignMode)
      {
        _presenter = new MainViewPresenter(this, manager);
        _presenter.Setup();
      }
    }

    public void SetupView()
    {
      var model = _presenter.Model;

      DataBindings.Add(new Binding("Text", model, "Title", false));
      txtName.DataBindings.Add(new Binding("Text", model, "Name", false));
      txtResult.DataBindings.Add(new Binding("Text", model, "Message", false));
    }

    private void btnExec_Click(object sender, EventArgs e)
    {
      _presenter.ButtonClicked();
    }
  }
}