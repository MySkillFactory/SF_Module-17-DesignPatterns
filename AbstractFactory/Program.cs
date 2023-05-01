// Паттерн Abstract Factory позволяет нам создавать
// Пример https://github.com/SkillfactoryCoding/PatternsModule/tree/main/AbstractFactoryRealExample
// группы связанных объектов без привязки к конкретным классам.

/* 1. Определим модели объектов, которые будет создавать наша фабрика
 * класс Products.cs
 * 2. Общий базовый интерфейс фабрики и две его реализации
 * интерфейс IAbstractFactory.cs
 * 3. Используем это в той части приложения, где есть необходимость создания таких объектов
 * класс Client
 * 
 * Смысл здесь как раз в задании общего интерфейса для создания всех доступных типов продуктов.
 * Каждая конкретная реализация потом используется для создания продуктов нужного типа.
 */

using AbstractFactory;

Console.ReadKey();

/// <summary>
/// Класс, в котором нужно предусмотреть создание объектов фабрикой
/// </summary>
class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    /// <summary>
    ///  Конструктор класса, в котором происходит создание объектов фабрики
    /// </summary>
    public Client (IAbstractFactory factory)
    {
        _abstractProductA = factory.CreateProductA();
        _abstractProductB = factory.CreateProductB();
    }

    /// <summary>
    ///  Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
    /// </summary>
    public void Run()
    { }
}