using System;
namespace BanditoGansterito
{
    public interface IObserver
    {
     string Name { get; set; }//добавляем свойство в интерфейс
     void Update(Object ob);//Обновить информацию наблюдателей
      
    }
}
