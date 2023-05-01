using System;
namespace FactoryMethodRealExample
{
	class EmailMessageSender : MessageSender
	{
        /// <summary>
        /// Класс для рассылки e-mail
        /// </summary>
        public EmailMessageSender(string @from) : base(@from)
		{ }

        public override Message Send(string text)
        {
            return new EmailMessage();
        }
    }
}

