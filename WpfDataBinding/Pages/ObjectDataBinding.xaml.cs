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
    /// Interaktionslogik für ObjectDataBinding.xaml
    /// </summary>
    public partial class ObjectDataBinding : Page
    {
        public MainWindow mWindow { get; set; }
        Person p { get; set; }

        public ObjectDataBinding(MainWindow _mw)
        {
            this.mWindow = _mw;
            InitializeComponent();
            p = new Person("Brandner", "Christoph", new DateTime(1983, 1, 1), SexCd.Male);
            this.DataContext = p;
        }

        private void showData_btnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(p.ToString());
        }
    }
}
