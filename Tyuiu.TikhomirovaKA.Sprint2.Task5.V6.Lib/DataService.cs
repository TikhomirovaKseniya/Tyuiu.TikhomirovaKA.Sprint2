using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string m = "";
            string k = "";
            if (value1 >= 1 && value1 <= 4)
            {
                switch (value1)
                {
                    case 1: m = "пик"; break;
                    case 2: m = "треф"; break;
                    case 3: m = "бубен"; break;            
                    case 4: m = "черв"; break;
                }
            }
            if (value2 >= 6 && value2 <= 14)
            {
                switch (value2)
                {
                    case 6: k = "Шестёрка "; break;
                    case 7: k = "Семёрка "; break;
                    case 8: k = "Восьмёрка "; break;
                    case 9: k = "Девятка "; break;
                    case 10: k = "Десятка "; break;
                    case 11: k = "Валет "; break;
                    case 12: k = "Дама "; break;
                    case 13: k = "Король "; break;
                    case 14: k = "Туз "; break;
                }
            }
            return k + m;
        }
    }
}
