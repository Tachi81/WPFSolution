using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Lesson11ListBoxAndObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<string> ListOfNames = new ObservableCollection<string>()
        {
            "Kayah",
            "Marek",
            "Anna"
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = ListOfNames;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NameText.Text))
            {
                ListOfNames.Add(NameText.Text);
            }

        }

        private void RemoveBtnClick(object sender, RoutedEventArgs e)
        {
            if (NamesList.SelectedIndex >= 0)
            {
                ListOfNames.RemoveAt(NamesList.SelectedIndex);
            }

        }
    }
}
