using System;
using FinalTask.Models;

namespace FinalTask.Profiles
{
	/// <summary>
	/// Профиль для расчетра ставки по проекту "Обычный"
	/// </summary>
	public class RegularProjectCalculateProfile : ICalculatorProfile
	{
        public void CalculateInterest(Account account)
        {
            account.Type = "Обычный";
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
            {
                account.Interest -= account.Balance * 0.2;
            }

            if (account.Balance < 50000)
            {
                account.Interest -= account.Balance * 0.4;
            }

            Console.WriteLine($"Ваш проект \"Обычный\", баланс: {account.Balance} и ваша ставка: {account.Interest}%");
        }
    }
}

