using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;

namespace WpfApp1.model
{
    class Person
    {
        public int ID { get; set; }
        public int VerieryID { get; set; }
        public int StatusID { get; set; }
        public long Inn { get; set; }
        public string Type { get; set; }
        public long Shifer { get; set; }
        public DateTime Data { get; set; }

        public Person() { }

        public Person (int id, int verieryID, int statusID, long inn, string type, long shifer, DateTime data)
        {
            this.ID = id;
            this.VerieryID = verieryID;
            this.StatusID = statusID;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }

        public Person CopyFromCompanyDPO(PersonDPO pers)
        {
            StatusViewModel status = new StatusViewModel();
            int statid = 0;
            foreach (var Reg in status.ListStat)
            {
                if (Reg.Status == pers.StatusID)
                {
                    statid = Reg.ID;
                    break;
                }
            }

            VerietyViewModel veri = new VerietyViewModel();
            int verietyid = 0;
            foreach (var veriety in veri.ListVeriety)
            {
                if (veriety.Veriety == pers.VerieryID)
                {
                    verietyid = veriety.ID;
                    break;
                }
            }

            //OrgLegViewModel vmLeg = new OrgLegViewModel();
            //int LegId = 0;
            //foreach (var leg in vmLeg.ListLeg)
            //{
            //    if (leg.NameShort == comp.OrgLegFormID)
            //    {
            //        LegId = leg.ID;
            //        break;
            //    }
            //}

            if ((statid != 0) && (verietyid != 0))
            {
                this.ID = pers.ID;
                this.VerieryID = verietyid;
                this.StatusID = statid;
                this.Inn = pers.Inn;
                this.Type = pers.Type;
                this.Shifer = pers.Shifer;
                this.Data = pers.Data;
            }
            return this;
        }


    }
}
