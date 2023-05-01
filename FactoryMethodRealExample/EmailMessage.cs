using System;
namespace FactoryMethodRealExample
{
	class EmailMessage : Message
	{
		public EmailMessage()
		{
			Console.WriteLine("E-Mail отправлен");
		}
	}
}

