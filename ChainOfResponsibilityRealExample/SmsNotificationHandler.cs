using System;
namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// Обработчик SMS-уведомлений
    /// </summary>
    class SmsNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.VoiceNotification == true)
                Console.WriteLine("Выполнено уведомление по SMS");

            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}

