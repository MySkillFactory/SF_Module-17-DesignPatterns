using AdapterRealExample;
using AdapterRealExample.Devices;
/* Пример использования Структурного паттерна - Adapter:
* Есть программа, которая отправляет на печать изображения сторонним устройствам.
* Для печати изображений у вас есть класс ImageDrawer.
* В нём вы работаете с принтером, у него есть понятный интерфейс,
* который вы себе подключили.
* В какой-то момент вам становится необходимо добавить поддержку печати на холсте,
* но в классе ImageDrawer использование печати на холсте не предусмотрено,
* поэтому нужно либо переписать его, либо можно использовать адаптер. 
*/

// Нам надо отрисовать изображение на бумаге и холсте
// Запускаем класс для отрисовки
var imageDrawer = new ImageDrawer();

// Создаем класс для работы с бумажным принтером
PaperPrinter paperPrinter = new PaperPrinter();
// Запускаем отрисовку на бумаге
imageDrawer.DraweWith(paperPrinter);

// Теперь нужна печать на холсте
CanvasPainter canvasPainter = new CanvasPainter();

// Используем адаптер
IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
// Запускаем печать на холсте
imageDrawer.DraweWith(imagePrinter);

Console.ReadKey();