using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.ViewModel
{
    class PhoneViewModel
    {
        public ObservableCollection<PhonePerson> Listphone { get; set; } = new ObservableCollection<PhonePerson>();

        public PhoneViewModel()
        {
            this.Listphone.Add(new PhonePerson(1, 1, 06430643));


        }
    }
}
