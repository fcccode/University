using Labarator_1.ViewModel;
using System.Windows;

namespace Labarator_1.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
