using AbstractFactoryRealExample;
using AbstractFactoryRealExample.Factories;

// Create Dragon
var dragon = new Monster(new DragonFactory());
Console.WriteLine("Создан Дракон");
dragon.Move();
dragon.Hit();

Console.WriteLine("\nСоздан Орк");
// Create Orc
var orc = new Monster(new OrcFactory());
orc.Move();
orc.Hit();

Console.ReadKey();