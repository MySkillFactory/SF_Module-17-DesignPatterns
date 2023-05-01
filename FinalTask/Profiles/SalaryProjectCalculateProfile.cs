using System;
using FinalTask.Models;

namespace FinalTask.Profiles
{
    /// <summary>
    /// Профиль для расчетра ставки по проекту "Зарплатный"
    /// </summary>
    public class SalaryProjectCalculateProfile : ICalculatorProfile
    {
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
            Console.WriteLine($"Ваш проект \"Зарплатный\", баланс: {account.Balance} и ваша ставка: {account.Interest}%");
        }
    }
}

