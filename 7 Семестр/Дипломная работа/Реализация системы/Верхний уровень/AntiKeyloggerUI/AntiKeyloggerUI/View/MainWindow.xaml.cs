using AntiKeyloggerUI.Auxiliary;
using AntiKeyloggerUI.Properties;
using AntiKeyloggerUI.ViewModel;

using System.ComponentModel;
using System.Windows;

namespace AntiKeyloggerUI.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UiDispatcherHelper.Initialize();
            DataContext = new MainViewModel();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();
            base.OnClosing(e);
        }
    }
}
