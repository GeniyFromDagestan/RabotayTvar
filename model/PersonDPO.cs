using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;

namespace WpfApp1.model
{
    class PersonDPO
    {
        public int ID { get; set; }
        public string VerieryID { get; set; }
        public string StatusID { get; set; }
        public long Inn { get; set; }
        public string Type { get; set; }
        public long Shifer { get; set; }
        public DateTime Data { get; set; }

        public PersonDPO() { }

        public PersonDPO(int id, string verieryID, string statusID, long inn, string type, long shifer, DateTime data)
        {
            this.ID = id;
            this.VerieryID = verieryID;
            this.StatusID = statusID;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }

        public PersonDPO CopyFromPerson(Person pers)
        {
            PersonDPO persDPO = new PersonDPO();

            StatusViewModel status = new StatusViewModel();
            string statStr = string.Empty;
            foreach (var Reg in status.ListStat)
            {
                if (Reg.ID == pers.StatusID)
                {
                    statStr = Reg.Status;
                    break;
                }
            }

            VerietyViewModel veri = new VerietyViewModel();
            string verStr = string.Empty;
            foreach (var veriety in veri.ListVeriety)
            {
                if (veriety.ID == pers.VerieryID)
                {
                    verStr = veriety.Veriety;
                    break;
                }
            }

         

            if ((statStr != string.Empty) && (verStr != string.Empty))
            {
                persDPO.ID = pers.ID;
                persDPO.VerieryID = verStr;
                persDPO.StatusID = statStr;
                persDPO.Inn = pers.Inn;
                persDPO.Type = pers.Type;
                persDPO.Shifer = pers.Shifer;
                persDPO.Data = pers.Data;
            }
            return persDPO;
        }


    }
}
