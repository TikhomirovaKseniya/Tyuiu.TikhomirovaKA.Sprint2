using Tyuiu.TikhomirovaKA.Sprint2.Task2.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила Тихомирова К. А. | ИБКСб-25-1";

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                              *");
        Console.WriteLine("* Задание #2                                                             *");
        Console.WriteLine("* Вариант #4                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Введите точку X                                                        *");
        int x;
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("* Введите точку Y                                                        *");
        int y;
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        if (ds.CheckDotInShadedArea(x, y) == true)
        {
            Console.WriteLine("Точка принадлежит области");
        }
        else 
        {
            Console.WriteLine("Точка не принадлежит области");
        }
        Console.ReadKey();
    }
}