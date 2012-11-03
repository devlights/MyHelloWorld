
namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Windows.Forms;

  public partial class MainForm : Form, IMainView
  {
    MainFormPresenter _presenter;

    public MainForm()
    {
      InitializeComponent();

      if (!DesignMode)
      {
        _presenter = new MainFormPresenter(this);
        _presenter.Setup();
      }
    }

    public void SetupView(MainFormPresenter presenter)
    {
      var model = presenter.Model;

      txtName.DataBindings.Add(new Binding("Text", model, "Name", false));
      txtResult.DataBindings.Add(new Binding("Text", model, "Message", false));

      btnExec.Click += presenter.ButtonClicked;
    }
  }
}