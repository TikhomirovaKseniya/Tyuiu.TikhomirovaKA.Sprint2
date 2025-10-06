using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            string n = string.Empty;
            if (value >= 1 &&  value <= 7)
            {
                switch (value)
                {
                    case 1: n = "понедельник"; break;
                    case 2: n = "вторник"; break;
                    case 3: n = "среда"; break;
                    case 4: n = "четверг"; break;
                    case 5: n = "пятница"; break;
                    case 6: n = "суббота"; break;
                    case 7: n = "воскресенье"; break;
                }                
            }
            return n;
        }
    }
}
