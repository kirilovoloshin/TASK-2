using System.Windows;
using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.View;

namespace WpfApp1.ViewModel;

public class EndGameViewModel
{
    public string ResultMessage { get; set; }
    public ICommand StartNewGame { get; }

    public EndGameViewModel(string resultMessage, Window father)
    {
        
        StartNewGame = new WindowCommand(x =>
        {
            new HelloWindow().Show();
            x.Close();
            father.Close();
        });
        ResultMessage = resultMessage;
    }
}