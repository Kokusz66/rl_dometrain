using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorWebAppDemo.Components.Demos.Part4.CascadingParametersDemo;

public class CascadingModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private string _someText = string.Empty;
    public string SomeText
    {
        get { return _someText; }
        set
        {
            _someText = value;
            OnPropertyChanged();

        }
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
