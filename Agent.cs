using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanditoGansterito
{
    class Agent:IObserver
    {
        //Агент под прикрытием FBI

        public string Name { get; set; }

        public Agent(string name)
        {
            // Агент получает кодовое имя
            this.Name =name;
            // внедряется в банду
            IObservable banda = GanstersGroup.GetInstance();
            banda.RegisterObserver(this);
        }
        
           // Докладывает в штаб ФБР
            public void Update(object ob)
            {
                DateInfo dateInfo = (DateInfo)ob;
            Console.WriteLine($"На связи агент  {this.Name} : известна дата ограбления! {dateInfo.Date}");
                
        }

    }
}
