using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task4.V2.Lib
{
    public class DataService : ISprint2Task4V2
    {
        public double Calculate(double x, double y)
        {
            double z = (x > (y + 3)) ? Math.Round(x + ((x + 1) / y), 3) : Math.Round((y + 5) / (y + 2), 3);
            return z;
        }
    }
}
