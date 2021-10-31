using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
    class PhonePerson
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int Phone { get; set; }

        public PhonePerson() { }
        
        public PhonePerson(int id, int personID, int phone)
        {
            this.ID = id;
            this.PersonID = personID;
            this.Phone = phone;
        }

        public PhonePerson ShallowCopy()
        {
            return (PhonePerson)this.MemberwiseClone();
        }
    }
}
