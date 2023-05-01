using System;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    /// Фабрика по производству драконов
    /// </summary>
    public class DragonFactory : IMonsterFactory
	{
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}

