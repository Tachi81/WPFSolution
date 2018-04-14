using System.Collections.Generic;
using System.Windows;

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


            List<CustomImage> customimages = new List<CustomImage>
            {
                new CustomImage("logo.jpg","logo"),

            };

            List<CustomImage> holidayImgs = new List<CustomImage>
            {
                new CustomImage("logo.jpg","logo"),
                new CustomImage("logo1.jpg","logo"),
                new CustomImage("logo.jpg","logo"),
                new CustomImage("logo2.jpg","logo"),
                new CustomImage("logo.jpg","logo")
            };

            List<CustomImage> familyimgs = new List<CustomImage>
            {
                new CustomImage("logo2.jpg","logo"),
                new CustomImage("logo1.jpg","logo"),
                new CustomImage("logo.jpg","logo"),
                new CustomImage("logo2.jpg","logo"),
                new CustomImage("logo2.jpg","logo")
            };
            this.DataContext = customimages;
            Family.DataContext = familyimgs;
            Holidays.DataContext = holidayImgs;
        }
    }
}
