using System;
namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// Получатель уведомлений
    /// </summary>
    public class Receiver
	{
        // банковские переводы
        public bool EmailNotification { get; set; }
        // денежные переводы - WesternUnion, Unistream
        public bool SmsNotification { get; set; }
        // перевод через PayPal
        public bool VoiceNotification { get; set; }

        public Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
        {
            EmailNotification = emailNotification;
            SmsNotification = smsNotification;
            VoiceNotification = voiceNotification;
        }
    }
}

