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
using System.Windows.Shapes;
using WpfApp1.model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowVeriety.xaml
    /// </summary>
    public partial class WindowVeriety : Window
    {
        VerietyViewModel vmveri = new VerietyViewModel();

        public WindowVeriety()
        {
            InitializeComponent();
            WNPveri.ItemsSource = vmveri.ListVeriety;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewVeriety wnpver = new WindowNewVeriety
            {
                Title = "Проверка вида клиента",
                Owner = this
            };
            int maxIdver = vmveri.MaxId() + 1;
            VerietyPerson ver = new VerietyPerson 

            {
                ID = maxIdver
            };
            wnpver.DataContext = ver;
            if (wnpver.ShowDialog() == true)
            {
                vmveri.ListVeriety.Add(ver);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewVeriety wnpver = new WindowNewVeriety
            {
                Title = "Редактирование",
                Owner = this
            };
            VerietyPerson ver = WNPveri.SelectedItem as VerietyPerson;
            if (ver != null)
            {
                VerietyPerson veriety = ver.ShallowCopy();
                wnpver.DataContext = veriety;
                if (wnpver.ShowDialog() == true)
                {
                    ver.Veriety = veriety.Veriety;


                    WNPveri.ItemsSource = null;
                    WNPveri.ItemsSource = vmveri.ListVeriety;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            VerietyPerson ver = (VerietyPerson)WNPveri.SelectedItem;
            if (ver != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " +
                ver.Veriety, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmveri.ListVeriety.Remove(ver);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
