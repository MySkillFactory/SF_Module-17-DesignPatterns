using System;
namespace ObserverRealExample.Observers
{
    /// <summary>
    /// Реализация брокера в качестве наблюдателя
    /// </summary>
    class Broker : IObserver
    {
        IObservable stock;

		public Broker(IObservable obs)
		{
            stock = obs;
            stock.RegisterObserver(this);
		}

        public void Update(object o)
        {
            StockData stockData = (StockData)o;

            if (stockData.USD > 85)
                Console.WriteLine($"Брокер продает доллары  по курсу {stockData.USD}");
            else
                Console.WriteLine($"Брокер покупает доллары  по курсу {stockData.USD}");
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}

