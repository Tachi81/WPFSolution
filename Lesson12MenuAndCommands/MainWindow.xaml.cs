using System.Windows;
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
            InitializeComponent();
        }
    }
}
