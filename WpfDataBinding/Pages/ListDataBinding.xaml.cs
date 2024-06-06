using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfDataBinding.Models;

namespace WpfDataBinding.Pages
{
    /// <summary>
    /// Interaktionslogik für ListDataBinding.xaml
    /// </summary>
    public partial class ListDataBinding : Page
    {
        public MainWindow MainWindow { get; set; }
        ObservableCollection<Person> Persons { get; set; } // ObservableCollection: dynamische Datensammlung, welche Benachrichtigungen sendet wenn es Änderungen in der Sammlung gibt
        public ListDataBinding(MainWindow _mw)
        {
            this.MainWindow = _mw;
            InitializeComponent();
            InitData();
            PersonListView.ItemsSource = this.Persons;
            this.personDetail_StackPanel.Visibility = Visibility.Collapsed;
        }

        private void InitData()
        {
            this.Persons = new ObservableCollection<Person>();

            Persons.Add(new Person("Schüler", "Sigi", new DateTime(2010, 12, 31), SexCd.Male));
            Persons.Add(new Person() { Name = "Teilweise", SexCd=SexCd.Male, Firstname="Tommy" });
            Persons.Add(new Person("Auinger", "Anita", new DateTime(2007, 6, 1), SexCd.Female));

        }

        private void PersonListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person curPerson = (Person)PersonListView.SelectedItem;
            if ((curPerson != null))
            {
                this.personDetail_StackPanel.Visibility = Visibility.Visible;
                this.personDetails.Content = $"{curPerson.ToString()} ({curPerson.DateOfBirth})";
            }
            else
                this.personDetail_StackPanel.Visibility = Visibility.Collapsed;

        }

        private void addPerson_btnClick(object sender, RoutedEventArgs e)
        {
            string[] arrFirstname = new string[] { "Manuela" , "Johanna", "Siglinde", "Eva", "Maria", "Tanja", "Nina", "Susi", "Bettina", "Lana"};
            Random rnd = new Random();
            this.Persons.Add(new Person("Neuer", arrFirstname[rnd.Next(arrFirstname.Length)], new DateTime(2000,1,1), SexCd.Female));
            PersonListView.ItemsSource = this.Persons;
        }
    }
}
