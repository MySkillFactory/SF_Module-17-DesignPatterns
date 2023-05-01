using System;
namespace ObserverRealExample.Observers
{
    /// <summary>
    /// Общий интерфейс наблюдателя
    /// </summary>
    interface IObserver
    {
        // метод Update() для получения информации
        void Update(Object o);
    }
}

