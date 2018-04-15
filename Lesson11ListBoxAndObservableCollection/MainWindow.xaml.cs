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

        ObservableCollection<Person> ListOfPeople = new ObservableCollection<Person>()
        {
           new Person() {Name= "Kayah", Position = "Director"},
            new Person() {Name= "Konrad", Position = "Manager"},
            new Person() {Name= "Olga", Position = "Office Manager"}

        };
        ObservableCollection<Status> ListOfStatusses = new ObservableCollection<Status>();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = ListOfPeople;
            StatusListSection.DataContext = ListOfStatusses;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NameText.Text))
            {
                ListOfPeople.Add(new Person() { Name = NameText.Text });
            }

        }

        private void RemoveBtnClick(object sender, RoutedEventArgs e)
        {
            if (NamesList.SelectedIndex >= 0)
            {
                ListOfPeople.RemoveAt(NamesList.SelectedIndex);
            }

        }

        private void AddStatusBtn(object sender, RoutedEventArgs e)
        {
            int statusWeight = Int32.Parse(StatusWeightText.Text);
            if (statusWeight < 0)
            {
                statusWeight = 0;
            }

            if (statusWeight > 100)
            {
                statusWeight = 100;
            }

            string isActive = (bool)IsActiveChkBox.IsChecked ? "On" : "Off";
            ListOfStatusses.Add(new Status() { StatusName = StatusNameText.Text, IsActive = isActive, Weight = statusWeight });
        }
    }
}
