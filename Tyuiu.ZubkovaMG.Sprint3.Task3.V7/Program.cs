using Tyuiu.ZubkovaMG.Sprint3.Task3.V7.Lib;

namespace Tyuiu.ZubkovaMG.Sprint3.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4 в строке: gft hggt ntg *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + replaceable);
            Console.WriteLine("Символ на замену = " + replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}