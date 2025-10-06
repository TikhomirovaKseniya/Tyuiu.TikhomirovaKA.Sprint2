using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1) y = Math.Round(x + Math.Pow((x + 1) / (x - 1), x), 3); else
            if (x == 0) y = Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12), 3); else
            if (x >= -19 && x <= 2) y = Math.Round((Math.Pow((1 + (1 / (Math.Pow(x, 2)))), 8)), 3); else
            if (x < -19) y = Math.Round(x + 10 * x - (1 / x), 3);
            return y;
        }
    }
}
