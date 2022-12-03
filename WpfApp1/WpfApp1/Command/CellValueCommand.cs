using System;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.Command;

public class CellValueCommand : ICommand
{
    private readonly Action<CellModel> _action;

    public CellValueCommand(Action<CellModel> act)
    {
        _action = act;
    }
    public bool CanExecute(object parameter)
    {
        if (parameter is CellModel model )
        {
            return model.Value == null;
        }
        return false;
    }

    public void Execute(object parameter)
    {
        _action.Invoke((CellModel)parameter);
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}