using Tyuiu.ZubkovaMG.Sprint3.Task4.V1.Lib;
namespace Tyuiu.ZubkovaMG.Sprint3.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке от -5 до 5 вычислить значение функции y = sin(x)/x.          *");
            Console.WriteLine("* При x = 0 прервать цикл. Полученные значения суммировать.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Сумма ряда равна = " + res);

            Console.ReadKey();
        }
    }
}