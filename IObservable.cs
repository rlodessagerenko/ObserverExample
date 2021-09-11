using System;
namespace BanditoGansterito
{
    public interface IObservable
    {
		void RegisterObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObservers();
    }
}
