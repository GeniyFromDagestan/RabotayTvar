using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
        class StatusPerson
        {
            public int ID { get; set; }
            public string Status { get; set; }
            public StatusPerson() { }
            public StatusPerson(int id, string status)
            {
                this.ID = id;
                this.Status = status;
            }

            public StatusPerson ShallowCopy()
            {
                return (StatusPerson)this.MemberwiseClone();
            }
        }
}

