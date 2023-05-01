using System;
using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;

namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    ///  Интерфейс абстрактной фабрики
    /// </summary>
    public interface IMonsterFactory
	{
        IMovement CreateMovement();
        IWeapon CreateWeapon();
	}
}

