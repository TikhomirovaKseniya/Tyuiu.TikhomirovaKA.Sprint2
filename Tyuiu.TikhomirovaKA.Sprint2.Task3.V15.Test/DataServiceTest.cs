using Tyuiu.TikhomirovaKA.Sprint2.Task3.V15.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 4;

            double res = ds.Calculate(x);
            Assert.AreEqual(11.716, res);
        }
    }
}
