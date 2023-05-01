// Паттерн SINGLETON (ОДИНОЧКА)
// Одна точка входа в классе.
// Например подключение к БД или создастся или вернёт состояние,
// но не будет создавать подключение каждый раз.

// создаем объект приложения
Application app = new ();


app.Launch("192.168.1.1");
Console.WriteLine(app.DbConnection.Configuration);

// запускаем наше приложение (внутри создается соединение с базой данных по переданному адресу)
app.DbConnection = DbConnection.GetConnectionInstance("192.168.1.2");

// Теперь пробуем создать новое соединение с базой данных уже по другому адресу
Console.WriteLine(app.DbConnection.Configuration);

// у нас не получилось, так как объект уже существует
Console.ReadKey();

/// <summary>
/// Простой пример
/// </summary>
class Singelton
{
    // Статическая переменная - ссылка на конкретный экземпляр объекта
    private static Singelton Instance;

    // Приватный конструктор
    private Singelton()
    { }

    // Здесь конструктор вызывается для создания объекта если он отсутствует
    // или равен null
    public static Singelton GetInstance()
    {
        if (Instance == null)
            Instance = new Singelton();

        return Instance;
    }
}

/// <summary>
/// Пример с подключением к БД
/// </summary>
class DbConnection
{
    private static DbConnection Connection;

    public string Configuration { get; private set; }

    protected DbConnection(string configuration)
    {
        Configuration = configuration;
    }

    /// <summary>
    /// Реализация синглтона не позволяет нам пложить новые объекты если объект уже существует
    /// </summary>
    public static DbConnection GetConnectionInstance(string dbServer)
    {
        if (Connection == null)
            Connection = new DbConnection(dbServer);
        return Connection;
    }
}

/// <summary>
/// Класс - приложение
/// </summary>
class Application
{
    public DbConnection DbConnection { get; set; }
    public void Launch(string dbServer)
    {
        DbConnection = DbConnection.GetConnectionInstance(dbServer);
    }
}