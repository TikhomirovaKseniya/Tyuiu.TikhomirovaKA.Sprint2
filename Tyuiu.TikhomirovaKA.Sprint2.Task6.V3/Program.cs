using Tyuiu.TikhomirovaKA.Sprint2.Task6.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                              *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Введите номер дня недели                                               *");
        int value;
        value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.FindDayName(value));
        Console.ReadKey();
    }
}