using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.Command;

public class WindowCommand : ICommand
{
    private readonly Action<Window> _action;

    public WindowCommand(Action<Window> act)
    {
        _action = act;
    }

    public bool CanExecute(object parameter)
    {
        return parameter is Window;
    }

    public void Execute(object parameter)
    {
        _action.Invoke(parameter as Window);
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}