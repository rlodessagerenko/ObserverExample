using System;
namespace BanditoGansterito
{
    public interface IObservable
    {           
		void RegisterObserver(IObserver o);//Регистрировать наблюдателей
		void RemoveObserver(IObserver o);//Удалить наблюдателей
		void NotifyObservers();//Оповестить наблюдателей
    }
}
