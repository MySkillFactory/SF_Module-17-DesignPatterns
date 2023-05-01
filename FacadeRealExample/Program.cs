using FacadeRealExample;
using FacadeRealExample.Components;

/* Реальный пример использования паттерна Facade
 * Реализация модели работы IDE с помощью паттерна Фасад на практике
 * (это также поможет немного глубже посмотреть на процессы работы в IDE).
 */

// При запуске IDE инициализирует объекты для работы с компонентами
Editor textEditor = new Editor();
Compiler compiler = new Compiler();
Runtime runtime = new Runtime();

// Модель IDE запущена и готова к использованию
IdeFacade ide = new IdeFacade(textEditor, compiler,runtime);

// Начинаем писать код и нажимаем кнопку Start
ide.Start("Console.WriteLine(\"Hello World!\");");

// запускается выполнение нашей программы
ide.Stop();

Console.ReadKey();

