using Tyuiu.TikhomirovaKA.Sprint2.Task0.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                              *");
        Console.WriteLine("* Задание #0                                                             *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
        Console.WriteLine("* последовательность операций не должна нарушаться)                      *");
        Console.WriteLine("* и арифметических выражений, которая вернет логическую                  *");
        Console.WriteLine("* последовательность(массив): (False, True, False, True, False, True),   *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* x = 45, y = 127                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        int x = 45;
        int y = 127;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}