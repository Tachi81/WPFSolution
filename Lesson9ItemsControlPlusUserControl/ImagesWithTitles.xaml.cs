using System.Windows.Controls;

namespace Lesson9ItemsControlPlusUserControl
{
    /// <summary>
    /// Interaction logic for ImagesWithTitles.xaml
    /// </summary>
    public partial class ImagesWithTitles : UserControl
    {
        public ImagesWithTitles()
        {
            InitializeComponent();
        }

        private double szerokosc;

        public double Szerokosc
        {
            get { return szerokosc; }
            set
            {
                szerokosc = value;
                this.Width = szerokosc / 2;
            }
        }

    }
}
