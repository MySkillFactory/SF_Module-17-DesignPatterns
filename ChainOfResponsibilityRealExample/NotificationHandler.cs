using System;
namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// Абстрактный базовый класс для всех обработчиков событий
    /// </summary>
    abstract class NotificationHandler
	{
		public NotificationHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
	}
}

