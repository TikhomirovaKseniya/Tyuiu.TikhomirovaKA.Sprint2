using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            bool area1, area2, area3;
            if (y > Math.Pow(x, 2)) area1 = true; else area1 = false;
            if (y < Math.Exp(x)) area2 = true; else area2 = false;
            if (y < Math.Exp(-x)) area3 = true; else area3 = false;

            if (area1 == true && area2 == true && area3 == true) res = true;
            return res;
        }
    }
}
