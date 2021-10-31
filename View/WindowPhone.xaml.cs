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
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPhone.xaml
    /// </summary>
    public partial class WindowPhone : Window
    {

        PhoneViewModel vmphone = new PhoneViewModel();

        public WindowPhone()
        {
            InitializeComponent();
            WNPphone.ItemsSource = vmphone.Listphone;
        }
        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowNewPerson wnPerson = new WindowNewPerson
        //    {
        //        Title = "Новый сотрудник",
        //        Owner = this
        //    };
        //    int maxIdPers = vmPerson.MaxId() + 1;
        //    PersonDPO persDPO = new PersonDPO
        //    {
        //        ID = maxIdPers
        //    };
        //    wnPerson.DataContext = persDPO;
        //    wnPerson.WNPstat.ItemsSource = statList;
        //    wnPerson.WNPveriety.ItemsSource = VerList;

        //    if (wnPerson.ShowDialog() == true)
        //    {
        //        StatusPerson stp = (StatusPerson)wnPerson.WNPstat.SelectedValue;
        //        VerietyPerson vp = (VerietyPerson)wnPerson.WNPveriety.SelectedValue;


        //        persDPO.StatusID = stp.Status;
        //        persDPO.VerieryID = vp.Veriety;

        //        PersonDPO.Add(persDPO);

        //        Person person = new Person();
        //        person = person.CopyFromCompanyDPO(persDPO);
        //        vmPerson.ListPerson.Add(person);
        //    }
        //}
        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowNewStatus wnpstatus = new WindowNewStatus
        //    {
        //        Title = "Редактирование",
        //        Owner = this
        //    };
        //    StatusPerson sts = WNPStatus.SelectedItem as StatusPerson;
        //    if (sts != null)
        //    {
        //        StatusPerson stats = sts.ShallowCopy();
        //        wnpstatus.DataContext = stats;
        //        if (wnpstatus.ShowDialog() == true)
        //        {
        //            sts.Status = stats.Status;


        //            WNPStatus.ItemsSource = null;
        //            WNPStatus.ItemsSource = vmstatus.ListStat;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Необходимо выбрать поле для редактированния",
        //        "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //}
        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    PersonDPO persDPO = (PersonDPO)Person.SelectedItem;
        //    if (persDPO != null)
        //    {
        //        MessageBoxResult result = MessageBox.Show("Удалить данные : \n" + "Строка с ID под номером: " + persDPO.ID,
        //        "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        //        if (result == MessageBoxResult.OK)
        //        {
        //            PersonDPO.Remove(persDPO);
        //            Person psn = new Person();
        //            psn = psn.CopyFromCompanyDPO(persDPO);
        //            vmPerson.ListPerson.Remove(psn);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Необходимо выбрать данные для удаления",
        //        "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }

        //}
    }
}
