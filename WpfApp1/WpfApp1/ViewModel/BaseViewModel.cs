using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.ViewModel;

public abstract class BaseViewModel :INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}