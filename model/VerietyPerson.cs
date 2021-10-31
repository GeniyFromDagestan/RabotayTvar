using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
    class VerietyPerson
    {
        public int ID { get; set; }
        public string Veriety { get; set; }
        public VerietyPerson() { }
        public VerietyPerson(int id, string veriety)
        {
            this.ID = id;
            this.Veriety = veriety;
        }

        public VerietyPerson ShallowCopy()
        {
            return (VerietyPerson)this.MemberwiseClone();
        }
    }
}
