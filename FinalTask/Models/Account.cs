using System;
using FinalTask.Profiles;

namespace FinalTask.Models
{
	public class Account
	{
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(double balance)
        {
            Balance = balance;
        }

        public void CalculateInterest(ICalculatorProfile calculatorProfile)
        {
            calculatorProfile.CalculateInterest(this);
        }

    }
}

