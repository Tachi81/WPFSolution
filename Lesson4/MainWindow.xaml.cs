using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson4Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      private  InkEditModes editModes = new InkEditModes();
        public MainWindow()
        {
            InitializeComponent();
            (this.Resources["Person"] as Person).Name = "Unknown";
            (this.Resources["Person"] as Person).Age = 0;
            (this.Resources["Person"] as Person).Email = "unknown@email.com";

        }
        public void GetOneFromList(object sender, RoutedEventArgs e)
        {
            var list = new List<string>() { "Marek", "Beata", "Paweł", "Seba", "Ala" };
            var random = new System.Random();
            (this.Resources["Person"] as Person).Name = list[random.Next(list.Count)];
        }
    }
}
