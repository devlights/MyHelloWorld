
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Windows.Forms;

  public partial class MainForm : Form, IMainView
  {
    MainViewPresenter _presenter;

    public MainForm()
    {
      InitializeComponent();

      if (!DesignMode)
      {
        _presenter = new MainViewPresenter(this);
        _presenter.Setup();
      }
    }

    public void SetupView(MainViewPresenter presenter)
    {
      var model = presenter.Model;

      DataBindings.Add(new Binding("Text", model, "Title", false));
      txtName.DataBindings.Add(new Binding("Text", model, "Name", false));
      txtResult.DataBindings.Add(new Binding("Text", model, "Message", false));

      btnExec.Click += presenter.ButtonClicked;
    }
  }
}