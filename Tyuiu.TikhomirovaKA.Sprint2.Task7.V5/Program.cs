using Tyuiu.TikhomirovaKA.Sprint2.Task7.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                              *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #5                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Введите значение X                                                     *");
        double x;
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите значение Y                                                     *");
        double y;
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        Console.ReadKey();
    }
}