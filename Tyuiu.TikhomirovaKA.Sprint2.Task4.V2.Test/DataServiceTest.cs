using Tyuiu.TikhomirovaKA.Sprint2.Task4.V2.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.429, res);
        }
    }
}
