using System;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.Command;

public class ChooseSideCommand : ICommand
{
    private readonly Action<CellValue> _action;

    public ChooseSideCommand(Action<CellValue> act)
    {
        _action = act;
    }
    public bool CanExecute(object parameter)
    {
        var parameters = parameter as object[];
        return Enum.TryParse(typeof(CellValue),parameters[0].ToString(), out var value);
    }

    public void Execute(object parameter)
    {
        var parameters = parameter as object[];
        _action.Invoke(Enum.Parse<CellValue>(parameters[0].ToString()));
        (parameters[1] as Window).Close();
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}