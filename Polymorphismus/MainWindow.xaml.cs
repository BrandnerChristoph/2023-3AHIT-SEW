using Polymorphismus.Classes;
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

namespace Polymorphismus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_12HFormat(object sender, RoutedEventArgs e)
        {
            Time12Format t = new Time12Format();
            MessageBox.Show(t.GetTime());
        }

        private void Button_24HFormat(object sender, RoutedEventArgs e)
        {
            Time24Format t = new Time24Format();
            MessageBox.Show(t.GetTime());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubClass c = new SubClass();
            this.cnt_out.Content = c.Test();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SubClass c = new SubClass();
            this.cnt_out.Content = c.Test(1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SubClass c = new SubClass();
            this.cnt_out.Content = c.Test("mein Text");
        }

        private void Button_Click_CallTestDynamic(object sender, RoutedEventArgs e)
        {
            try
            {
                SubClass c = new SubClass();

                if(string.IsNullOrEmpty(this.inTypCheck.Text))
                    this.secondContent.Content = c.Test();
                else
                {
                    int number;
                    bool success = int.TryParse(this.inTypCheck.Text, out number);
                    if (success)
                        this.secondContent.Content = c.Test(number);
                    else
                        this.secondContent.Content = c.Test(this.inTypCheck.Text);
                }


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
