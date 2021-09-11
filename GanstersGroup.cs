using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanditoGansterito
{
    // Клас описывающий сущность "Грабители банка"- Singleton
    class GanstersGroup:IObservable
    {
        private DateTime dateHeist; //Дата следующего ограбления
        private List<IObserver> gangsters;//члены банды
        private DateInfo dateInfo;//объект, который хранит информацию о дате грабежа
        // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
        // создание объекта через оператор new.
        private GanstersGroup() {
            gangsters = new List<IObserver>();
            Console.WriteLine("Создан список бандитов.");
            }

        // Объект одиночки храниться в статичном поле класса.
        private static GanstersGroup _instance;
        // Это статический метод, управляющий доступом к экземпляру одиночки.
        // При первом запуске, он создаёт экземпляр одиночки и помещает его в
        // статическое поле. При последующих запусках, он возвращает клиенту
        // объект, хранящийся в статическом поле.
        public static GanstersGroup GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GanstersGroup();
                
            }
            return _instance;
        }

        // Наконец, любой одиночка должен содержать некоторую бизнес-логику,
        // которая может быть выполнена на его экземпляре.
          
        public void RegisterObserver(IObserver o)
        {
            gangsters.Add(o);
            Console.BackgroundColor= ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( $"Внедрен в банду {o.Name}.");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void RemoveObserver(IObserver o)
        {
            gangsters.Remove(o);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ушел из банды {o.Name}.");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void NotifyObservers()//Сообщить всем членам банды информацию
        {
            foreach (IObserver o in gangsters)
            {
                o.Update(dateInfo);
            }
        }
        // получить дату ограбления
        public void GetDateHeist()
        {
            this.dateInfo = new DateInfo(DateTime.Now);
            this.dateHeist = dateInfo.Date;
            Console.WriteLine("Алькапоне назначил дату грабежа: {0}", this.dateHeist);
            this.NotifyObservers();
            
        }

      
    }

}

