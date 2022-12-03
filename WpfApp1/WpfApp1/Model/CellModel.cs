using WpfApp1.ViewModel;

namespace WpfApp1.Model;

public sealed class CellModel:BaseViewModel
{
    public Position Position;
    private CellValue? _value;
    public CellValue? Value { get => _value;
        set
        {
            _value = value;
            OnPropertyChanged();
        } }
}
public record Position(int X, int Y);

public enum CellValue
{
    Zero=0,
    Cross=1
}