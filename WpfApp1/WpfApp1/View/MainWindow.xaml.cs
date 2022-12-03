using System.Windows;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Value { get; set; }
        public MainWindow(CellValue value)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(value, this);
        }

           }
}