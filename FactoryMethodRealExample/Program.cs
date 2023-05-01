using FactoryMethodRealExample;

string messageText = "Ваш номер заказа 888";

// Отправляем по sms
MessageSender sender = new SmsMessageSender("808005553535");
Message SmsMessage = sender.Send(messageText);

// Отправляем по e-mail
sender = new EmailMessageSender("admin@example.com");
Message EmailMessage = sender.Send(messageText);

Console.ReadKey();