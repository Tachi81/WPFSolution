using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Lesson12MenuAndCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ApplicationCommands.Copy.InputGestures.Clear();
            ApplicationCommands.Copy.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            EditingCommands.IncreaseFontSize.InputGestures.Add(new KeyGesture(Key.Y, ModifierKeys.Alt));
            InitializeComponent();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
