using System;
namespace AdapterRealExample.Devices
{
	public class CanvasPainter : IPainter
	{
        /// <summary>
        /// Класс для работы с устройством,
        /// печатающим на холсте
        /// </summary>
        public void Paint()
        {
            Console.WriteLine("Рисуем на холсте");
        }
    }
}

