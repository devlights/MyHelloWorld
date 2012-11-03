namespace HelloWorld.Win
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;

  public class MainViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private string _name;
    private string _message;
    private string _title;

    public string Title
    {
      get { return _title; }
      set
      {
        if (_title == value)
          return;
        _title = value;
        OnPropertyChanged(this, new PropertyChangedEventArgs("Title"));
      }
    }

    public string Name
    {
      get { return _name; }
      set
      {
        if (_name == value)
          return;
        _name = value;
        OnPropertyChanged(this, new PropertyChangedEventArgs("Name"));
      }
    }

    public string Message
    {
      get { return _message; }
      set
      {
        if (_message == value)
          return;
        _message = value;
        OnPropertyChanged(this, new PropertyChangedEventArgs("Message"));
      }
    }

    protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null)
        handler(sender, e);
    }
  }
}
