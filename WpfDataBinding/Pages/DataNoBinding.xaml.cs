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
using WpfDataBinding.Models;

namespace WpfDataBinding.Pages
{
    /// <summary>
    /// Interaktionslogik für DataNoBinding.xaml
    /// </summary>
    public partial class DataNoBinding : Page
    {
        public MainWindow mWindow { get; set; }
        Person p { get; set; }
        public DataNoBinding(MainWindow _mw)
        {
            this.mWindow = _mw;
            InitializeComponent();
            p = new Person("Müller", "Elena", new DateTime(1989, 1, 1), SexCd.Female);
            this.DataContext = p;

            name_txtB.Text = p.Name;
            firstname_txtB.Text = p.Firstname;
            dateOfBirth_txtB.Text = p.DateOfBirth.ToString();
            sexCd_txtB.Text = p.SexCd.ToString();
        }
        private void showData_btnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
