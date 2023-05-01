using System;
namespace AbstractFactoryRealExample.Weapons
{
    public class Axe : IWeapon
    {
        /// <summary>
        /// Топор - оружие орков
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Бъем топором");
        }
    }
}

