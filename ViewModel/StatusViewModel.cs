using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.ViewModel
{
    class StatusViewModel
    {
        public ObservableCollection<StatusPerson> ListStat { get; set; } = new ObservableCollection<StatusPerson>();
        public StatusViewModel()
        {
            this.ListStat.Add(new StatusPerson
            {
                ID = 1,
                Status = "Онлайн"
            }) ;

            this.ListStat.Add(new StatusPerson
            {
                ID = 2,
                Status = "Оффлайн"
            });
        }
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListStat)
            {
                if (max < l.ID)
                {
                    max = l.ID;
                };
            }
            return max;
        }
    }
}
