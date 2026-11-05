using Tyuiu.ZubkovaMG.Sprint3.Task6.V19.Lib;
namespace Tyuiu.ZubkovaMG.Sprint3.Task6.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Посчитать количество всех делителей меньше 8 на отрезке [10, 15]        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 10;
            int stopValue = 15;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Количество делителей меньше 8 = " + res);

            Console.ReadKey();
        }
    }
}