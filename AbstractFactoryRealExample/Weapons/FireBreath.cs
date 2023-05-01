using System;
namespace AbstractFactoryRealExample.Weapons
{
    public class FireBreath : IWeapon
    {
        /// <summary>
        /// Оружие драконов - огненное дыхание
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}

