using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.ViewModel
{
    class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } = new ObservableCollection<Person>();
        public PersonViewModel()
        {
            this.ListPerson.Add(new Person
            {
                ID = 1,
                VerieryID = 1,
                StatusID = 1,
                Inn = 053035,
                Type = "bb",
                Shifer = 14214,
                Data = new DateTime(2000, 05, 10)
            }) ;
            this.ListPerson.Add(new Person
            {
                ID = 2,
                VerieryID = 2,
                StatusID = 2,
                Inn = 999,
                Type = "rabotaet",
                Shifer = 22,
                Data = new DateTime(1999, 06, 20)
            });
        }
        public int MaxId()
        {
            int max = 0;
            foreach (var a in this.ListPerson)
            {
                if (max < a.ID)
                {
                    max = a.ID;
                };
            }
            return max;
        }

    }
}
