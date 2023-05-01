using System;
namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// Обработчик голосовых уведомлений
    /// </summary>
    class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.SmsNotification == true)
                Console.WriteLine("Выполнено уведомление по телефону");

            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}

