using Assignment2_WPF.ViewModel;
using System.Windows;

namespace Assignment2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
            this.DataContext = new MainViewModel();
        }
    }
}
