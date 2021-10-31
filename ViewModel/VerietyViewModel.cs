using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.ViewModel
{
    class VerietyViewModel
    {
        public ObservableCollection<VerietyPerson> ListVeriety { get; set; } = new ObservableCollection<VerietyPerson>();
        public VerietyViewModel()
        {
            this.ListVeriety.Add(new VerietyPerson
            {
                ID = 1,
                Veriety = "Вип"
            });

            this.ListVeriety.Add(new VerietyPerson
            {
                ID = 2,
                Veriety = "Обычный"
            });


        }
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListVeriety)
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
