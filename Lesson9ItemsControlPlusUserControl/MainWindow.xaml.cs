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

namespace Lesson9ItemsControlPlusUserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<CustomImage>  customimages = new List<CustomImage>
            {
                new CustomImage("logo.jpg","logo"),
                new CustomImage("logo1.jpg","logo"),
                new CustomImage("logo.jpg","logo"),
                new CustomImage("logo2.jpg","logo"),
                new CustomImage("logo.jpg","logo")
            };
            this.DataContext = customimages;
        }
    }
}
