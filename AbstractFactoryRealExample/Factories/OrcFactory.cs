using System;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

namespace AbstractFactoryRealExample.Factories
{
    public class OrcFactory : IMonsterFactory
    {
        /// <summary>
        /// Фабрика по производству Орков
        /// </summary>
        /// <returns></returns>
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}

