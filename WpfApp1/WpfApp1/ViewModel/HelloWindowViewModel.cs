using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.ViewModel;

public class HelloWindowViewModel : BaseViewModel
{
    public ICommand ChooseSideCommand { get; }
    public CellValue Cross => CellValue.Cross;
    public CellValue Zero => CellValue.Zero;
    public HelloWindowViewModel()
    {
        ChooseSideCommand = new ChooseSideCommand(model =>
        {
            new MainWindow(model).Show();

        });
    }
    
}