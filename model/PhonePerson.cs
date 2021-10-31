using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;

namespace WpfApp1.model
{
    class PhonePerson
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public long Phone { get; set; }

        private Person person;
        public long Shifer { get; set; }


        public PhonePerson() { }

        public PhonePerson(int id, int personID, long phone)
        {
            this.ID = id;
            this.PersonID = personID;
            this.Phone = phone;

            var query = from ps in PersonViewModel.StaticListPerson
                        where ps.ID == id
                        select ps;
            foreach (var item in query)
            {
                this.person = item;
            }

            Shifer = person.Shifer;

        }

        public PhonePerson ShallowCopy()
        {
            return (PhonePerson)this.MemberwiseClone();
        }
    }
}
