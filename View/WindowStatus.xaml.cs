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
    /// Логика взаимодействия для WindowStatus.xaml
    /// </summary>
    public partial class WindowStatus : Window
    {
        StatusViewModel vmstatus = new StatusViewModel();

        public WindowStatus()
        {
            InitializeComponent();
            WNPStatus.ItemsSource = vmstatus.ListStat;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewStatus wnpstat = new WindowNewStatus
            {
                Title = "Проверка статуса",
                Owner = this
            };
            int maxIdstat = vmstatus.MaxId() + 1;
            StatusPerson sts = new StatusPerson
            {
                ID = maxIdstat
            };
            wnpstat.DataContext = sts;
            if (wnpstat.ShowDialog() == true)
            {
                vmstatus.ListStat.Add(sts);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewStatus wnpstatus = new WindowNewStatus
            {
                Title = "Редактирование",
                Owner = this
            };
            StatusPerson sts = WNPStatus.SelectedItem as StatusPerson;
            if (sts != null)
            {
                StatusPerson stats = sts.ShallowCopy();
                wnpstatus.DataContext = stats;
                if (wnpstatus.ShowDialog() == true)
                {
                    sts.Status = stats.Status;
                    

                    WNPStatus.ItemsSource = null;
                    WNPStatus.ItemsSource = vmstatus.ListStat;
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
            StatusPerson stat = (StatusPerson)WNPStatus.SelectedItem;
            if (stat != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " +
                stat.Status, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmstatus.ListStat.Remove(stat);
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
