using Tyuiu.TikhomirovaKA.Sprint2.Task5.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                              *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #6                                                             *");
        Console.WriteLine("* Выполнила: Выполнила Тихомирова К. А. | ИБКСб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Введите номер масти                                                    *");
        int value1, value2;
        value1 = Convert.ToInt32(Console.ReadLine());
        if (value1 < 1 || value1 > 4)
        {
            Console.WriteLine("Нет такой масти");
            Console.WriteLine("* Введите номер масти                                                    *");
            value1 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("* Введите номер достоинства                                              *");
        value2 = Convert.ToInt32(Console.ReadLine());
        if (value2 < 6 || value2 > 14)
        {
            Console.WriteLine("Нет такого достоинства карты");
            Console.WriteLine("* Введите номер достоинства                                              *");
            value2 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine(ds.FindCardNameAndValue(value1, value2));
        Console.ReadKey();
    }
}