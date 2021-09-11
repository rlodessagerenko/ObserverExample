using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanditoGansterito
{
    class Robber:IObserver
    {
        public string Name{ get; set; }

        public Robber(string name)
        {
            // Грабитель получает имя
             this.Name = name;
            // внедряется в банду
            IObservable banda = GanstersGroup.GetInstance();
            banda.RegisterObserver(this);

         }
        // Доложить
        public void Update(object ob)
        {
            DateInfo dateInfo = (DateInfo)ob;
           Console.WriteLine($"Внимание всем членам банды! {dateInfo.Date} Мы идем на ограбление! ");
        }
        
     }
}
