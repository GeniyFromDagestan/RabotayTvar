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
using System.Windows.Shapes;
using WpfApp1.model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        private PersonViewModel vmPerson;
        private StatusViewModel vmStatus;
        private VerietyViewModel vmVeriety;
        

        private ObservableCollection<PersonDPO> PersonDPO;

        private List<StatusPerson> statList;
        private List<VerietyPerson> VerList;
        
        public WindowPerson()
        {
            InitializeComponent();
            vmPerson = new PersonViewModel();
            vmStatus = new StatusViewModel();
            vmVeriety = new VerietyViewModel();


            statList = vmStatus.ListStat.ToList();
            VerList = vmVeriety.ListVeriety.ToList();


            PersonDPO = new ObservableCollection<PersonDPO>();
            foreach (var i in vmPerson.ListPerson)
            {
                PersonDPO pers = new PersonDPO();
                pers = pers.CopyFromPerson(i);
                PersonDPO.Add(pers);
            }
            Person.ItemsSource = PersonDPO;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPerson wnPerson = new WindowNewPerson
            {
                Title = "Новый сотрудник",
                Owner = this
            };
            int maxIdPers = vmPerson.MaxId() + 1;
            PersonDPO persDPO = new PersonDPO
            {
                ID = maxIdPers
            };
            wnPerson.DataContext = persDPO;
            wnPerson.WNPstat.ItemsSource = statList;
            wnPerson.WNPveriety.ItemsSource = VerList;
            
            if (wnPerson.ShowDialog() == true)
            {
                StatusPerson stp = (StatusPerson)wnPerson.WNPstat.SelectedValue;
                VerietyPerson vp = (VerietyPerson)wnPerson.WNPveriety.SelectedValue;


                persDPO.StatusID = stp.Status;
                persDPO.VerieryID = vp.Veriety;

                PersonDPO.Add(persDPO);

                Person person = new Person();
                person = person.CopyFromCompanyDPO(persDPO);
                vmPerson.ListPerson.Add(person);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PersonDPO persDPO = (PersonDPO)Person.SelectedItem;
            if (persDPO != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные : \n" + "Строка с ID под номером: " + persDPO.ID,
                "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning) ;
                if (result == MessageBoxResult.OK)
                {
                    PersonDPO.Remove(persDPO);
                    Person psn = new Person();
                    psn = psn.CopyFromCompanyDPO(persDPO);
                    vmPerson.ListPerson.Remove(psn);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
