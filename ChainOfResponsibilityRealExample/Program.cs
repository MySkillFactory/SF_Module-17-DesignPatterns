using ChainOfResponsibilityRealExample;

/* Реальный пример применения паттерна Chain Of Responsibility
 * Мы — банковский сервис, и должны уведомить человека об операции
 * на его счету любым доступным способом.
 * У клиента может быть предусмотрено несколько способов уведомления
 * (SMS, звонок, электронная почта), но нам неважно, какой из них использовать.
 */

Receiver receiver = new Receiver(false, true, true);

NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

emailNotificationHandler.Successor = smsNotificationHandler;
smsNotificationHandler.Successor = voiceNotificationHandler;

emailNotificationHandler.Handle(receiver);

Console.ReadKey();

/* Здесь с помощью конструктора и параметров, которые ему передаются,
 * мы установили возможные способы уведомления.
 * При необходимости отправки уведомления каждый объект NotificationHandler
 * будет проверять, установлен ли у получателя данный тип уведомления,
 * и если сопоставление выявит соответствие, уведомление будет отправлено.
 * Если необходимый способ не будет определен, уведомление не будет отправлено.
 * Здесь у нас есть возможность расположить обработчики по приоритету.
 */