using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanditoGansterito
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем классы интересующиеся деятельностью GangstersGroup
            Robber robber = new Robber("Bob");//бандит сторонней банды
            Agent scully = new Agent("Scully");//агент фбр
             Agent malder = new Agent("Malder");//агент фбр
            // И вот Дон Аль Капоне сообщил дату ограбления:
            GanstersGroup banda = GanstersGroup.GetInstance();
            banda.GetDateHeist();
            banda.RemoveObserver(scully);
            banda.RemoveObserver(malder);

            Console.ReadKey();
        }
    }
}


