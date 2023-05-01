using System;
namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// Обработчик e-mail уведомлений
    /// </summary>
    class EmailNotificationHandler : NotificationHandler
	{
        public override void Handle(Receiver receiver)
        {
            if (receiver.EmailNotification == true)
                Console.WriteLine("Выполнено уведомление по e-mail");
            
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}

