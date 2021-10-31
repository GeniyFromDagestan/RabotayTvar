using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
    class EmailPerson
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Email { get; set; }
        public EmailPerson() { }

        public EmailPerson(int id, int personID, string email)
        {
            this.ID = id;
            this.PersonID = personID;
            this.Email = email;
        }

        public EmailPerson ShallowCopy()
        {
            return (EmailPerson)this.MemberwiseClone();
        }
    }
}
