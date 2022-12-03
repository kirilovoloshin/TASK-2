using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1.View;

public partial class HelloWindow : Window
{
    public HelloWindow()
    {
        InitializeComponent();
        DataContext = new HelloWindowViewModel();
    }
    
}