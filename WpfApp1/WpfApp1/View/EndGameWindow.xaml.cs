using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1.View;

public partial class EndGameWindow : Window
{
    public EndGameWindow(string resultMessage, Window father)
    {
        InitializeComponent();
        DataContext = new EndGameViewModel(resultMessage, father);
    }
}