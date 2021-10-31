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
using WpfApp1.View;

namespace WpfApp1
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
        private void Person_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPerson wpers = new WindowPerson();
            wpers.Show();
        }

        private void Status_Click(object sender, RoutedEventArgs e)
        {
            WindowStatus stat = new WindowStatus();
            stat.Show();
        }

        private void Veriety_Click(object sender, RoutedEventArgs e)
        {
            WindowVeriety ver = new WindowVeriety();
            ver.Show();
        }
        //private void Reg_OnClick(object sender, RoutedEventArgs e)
        //{
        //    WindowReg wReg = new WindowReg();
        //    wReg.Show();
        //}
        //private void Person_OnClick(object sender, RoutedEventArgs e)
        //{
        //    WindowPerson wPerson = new WindowPerson();
        //    wPerson.Show();
        //}
        //private void Leg_OnClick(object sender, RoutedEventArgs e)
        //{
        //    WindowLeg wLeg = new WindowLeg();
        //    wLeg.Show();
        //}
        //public static int IdPerson { get; set; }
        //public static int IdCompany { get; set; }
    }
}
