using Server.Properties;
using Server.ViewModel;
using System.ComponentModel;
using System.Windows;

namespace Server.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();
            base.OnClosing(e);
        }
    }
}
