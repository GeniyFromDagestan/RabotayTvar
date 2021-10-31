using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.Helper
{
    class FindStatus
    {
        int id;
        public FindStatus(int id)
        {
            this.id = id;
        }
        public bool StatusPredict(StatusPerson stat)
        {
            return stat.ID == id;
        }
         
    }
}
