using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.ViewModel;

public class MainWindowViewModel : BaseViewModel
{
    private Window _owner;
    private const int _boardSize = 3;
    private CellValue? _playerValue=CellValue.Cross;
    const string Win = "Перемога за вами!";
    const string Lose = "Ви програли...";
    public CellValue? PlayerValue
    {
        get => _playerValue;
        set
        {
            _playerValue = value;
            OnPropertyChanged();
        }
    }

    private ObservableCollection<CellModel> _cells;

    public ObservableCollection<CellModel> Cells
    {
        get => _cells;
        set
        {
            _cells = value;
            OnPropertyChanged();
            
        }
    }

    public ICommand SetCellValue { get; }

    private CellModel _selectedCell;

    public CellModel SelectedCell
    {
        get => _selectedCell;
        set
        {
            _selectedCell = value;
            OnPropertyChanged();
        }
    }

    public MainWindowViewModel(CellValue value, Window owner)
    {
        _owner = owner;
        PlayerValue = value;
        SetCellValue = new CellValueCommand(x=>
        {
            x.Value = PlayerValue;
            CheckWin(x.Position.X,x.Position.Y, PlayerValue.Value);
            Move();
        });
        Cells = SetNewArea();
        if (value is CellValue.Zero)
            Move();
    }

    private void Move()
    {
        var freeIndexes = Cells.Select((c, i) => (c, i)).Where(x => x.c.Value == null).Select(x => x.i).ToArray();
        if (freeIndexes.Length > 0)
        {
            var randomIndex = new Random().Next(freeIndexes.Length);
            var value = PlayerValue == CellValue.Cross ? CellValue.Zero : CellValue.Cross;
            Cells[freeIndexes[randomIndex]].Value = value;
            CheckWin(Cells[freeIndexes[randomIndex]].Position.X,Cells[freeIndexes[randomIndex]].Position.Y,value);
        }
        else
        {
            ReturnDraw();
        }
    }

    private void CheckWin(int x, int y, CellValue value)
    {
        string returningText = value == PlayerValue ? Win : Lose;
        var board = Enumerable.Range(0, 3)
            .Select(c => Enumerable.Range(0, 3).Select(i => Cells[c * 3 + i]).ToArray()).ToArray();
        
        for(int i = 0; i < _boardSize; i++){
            if(board[x][i].Value != value)
                break;
            if(i == _boardSize-1)
            {
                new EndGameWindow(returningText, _owner).Show();
            }
        }
        
        for(int i = 0; i < _boardSize; i++){
            if(board[i][y].Value != value)
                break;
            if(i == _boardSize-1)
            {
                new EndGameWindow(returningText, _owner).Show();
            }
        }
        
        if(x == y){
            for(int i = 0; i < _boardSize; i++){
                if(board[i][i].Value != value)
                    break;
                if(i == _boardSize-1){
                    new EndGameWindow(returningText, _owner).Show();
                }
            }
        }
        
        if(x + y == _boardSize - 1){
            for(int i = 0; i < _boardSize; i++){
                if(board[i][(_boardSize-1)-i].Value != value)
                    break;
                if(i == _boardSize-1){
                    new EndGameWindow(returningText, _owner).Show();
                }
            }
        }
    }

    private void ReturnDraw()
    {
        new EndGameWindow("Нічия", _owner).Show();
    }
    private ObservableCollection<CellModel> SetNewArea()
    {
        return new ObservableCollection<CellModel>
        {
            new(){Position = new Position(0,0)},
            new(){Position = new Position(0,1)},
            new(){Position = new Position(0,2)},
            new(){Position = new Position(1,0)},
            new(){Position = new Position(1,1)},
            new(){Position = new Position(1,2)},
            new(){Position = new Position(2,0)},
            new(){Position = new Position(2,1)},
            new(){Position = new Position(2,2)},
        };
    }
}