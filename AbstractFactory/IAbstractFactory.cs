using System;
namespace AbstractFactory
{
    // 2. Общий базовый интерфейс фабрики и две его реализации

    /// <summary>
    /// Базовый интерфейс абстрактной фабрики
    /// </summary>
    interface IAbstractFactory
	{
        // Абстрактный метод для создания продукта A
        AbstractProductA CreateProductA();

        // Абстрактный метод для создания продукта B
        AbstractProductB CreateProductB();
    }

    /// <summary>
    ///  Первая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory1 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта A
        AbstractProductA IAbstractFactory.CreateProductA()
        {
            return new ProductA1();
        }

        // Конкретная реализация метода для создания продукта B
        AbstractProductB IAbstractFactory.CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    ///  Вторая конкретная реализация фабрики
    /// </summary>
    class ConcreteFactory2 : IAbstractFactory
    {
        // Конкретная реализация метода для создания продукта A
        AbstractProductA IAbstractFactory.CreateProductA()
        {
            return new ProductA2();
        }

        // Конкретная реализация метода для создания продукта B
        AbstractProductB IAbstractFactory.CreateProductB()
        {
            return new ProductB2();
        }
    }

