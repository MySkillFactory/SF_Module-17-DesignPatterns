using FacadeExample;

// Классическая реализация паттерна Facade

// Создание фасада
Facade facade = new Facade(new SystemOne(), new SystemTwo(), new SystemThree());

// Вызовы
facade.OperationOne();
facade.OperationTwo();

Console.ReadKey();