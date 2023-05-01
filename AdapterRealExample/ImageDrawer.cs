using System;
using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    /// <summary>
    /// Класс для отрисовки изображений
    /// </summary>
    public class ImageDrawer
	{
		public void DraweWith(IPrinter printer)
		{
			printer.Print();
		}
	}
}

