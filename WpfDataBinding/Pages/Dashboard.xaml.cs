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

namespace WpfDataBinding.Pages
{
    /// <summary>
    /// Interaktionslogik für Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public MainWindow mWindow { get; set; }
        public Dashboard(MainWindow _mw)
        {
            InitializeComponent();
            this.mWindow = _mw;
        }

        private void object_btnClick(object sender, RoutedEventArgs e)
        {
            this.mWindow.contentFrame.Content = new DataNoBinding(this.mWindow);
        }

        private void objectDataBinding_btnClick(object sender, RoutedEventArgs e)
        {
            this.mWindow.contentFrame.Content = new ObjectDataBinding(this.mWindow);
        }

        private void listDataBinding_btnClick(object sender, RoutedEventArgs e)
        {
            this.mWindow.contentFrame.Content = new ListDataBinding(this.mWindow);
        }
    }
}
