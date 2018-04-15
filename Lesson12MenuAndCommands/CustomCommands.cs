using System.Windows.Input;

namespace Lesson12MenuAndCommands
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit",
            typeof(CustomCommands), new InputGestureCollection()
            {
                new KeyGesture(Key.W,ModifierKeys.Control)
            });
    }
}
