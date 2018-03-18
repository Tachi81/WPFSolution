using System;
using System.Collections.Generic;
using System.Globalization;
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
using Lesson1;

namespace Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person = new Person();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
            person.Name = "Unknown";
            person.Age = 0;
            person.Email = "unknown@email.com";


        }
        public void GetOneFromList(object sender, RoutedEventArgs e)
        {
            var list = new List<string>() { "Marek", "Beata", "Paweł", "Seba", "Ala" };
            var random = new System.Random();
            person.Name= list[random.Next(list.Count )];
        }

        #region Rysowanie po apce
        //private InkEditModes inkEditModes = new InkEditModes();
        
        //private void Select_Click(object sender, RoutedEventArgs e)
        //{
        //    inkEditModes.EditingMode = InkCanvasEditingMode.Select;
        //    //inkCanvas.EditingMode = InkCanvasEditingMode.Select;
        //}

        //private void Draw_Click(object sender, RoutedEventArgs e)
        //{
        //    inkEditModes.EditingMode = InkCanvasEditingMode.Ink;
        //    //inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        //}
        #endregion
        
    }
}
