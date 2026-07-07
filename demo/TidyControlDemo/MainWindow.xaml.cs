using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TidyControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, ExecuteClose));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, ExecuteMinimize));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, ExecuteRestore));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, ExecuteMaximize));
            this.StateChanged += MainWindow_StateChanged;
            WindowState = WindowState.Normal;
            restore.Visibility = Visibility.Collapsed;
            max.Visibility = Visibility.Visible;
        }

        private void MainWindow_StateChanged(object? sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                restore.Visibility = Visibility.Visible;
                max.Visibility = Visibility.Collapsed;
            }
            else if (WindowState == WindowState.Normal)
            {
                restore.Visibility = Visibility.Collapsed;
                max.Visibility = Visibility.Visible;
            }
        }

        private void ExecuteMaximize(object sender, ExecutedRoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
            restore.Visibility = Visibility.Visible;
            max.Visibility = Visibility.Collapsed;
        }

        private void ExecuteRestore(object sender, ExecutedRoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            restore.Visibility = Visibility.Collapsed;
            max.Visibility = Visibility.Visible;
        }

        private void ExecuteMinimize(object sender, ExecutedRoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExecuteClose(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}