using Tyuiu.TikhomirovaKA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            int value = 5;
            string res = ds.FindDayName(value);
            Assert.AreEqual("пятница", res);
        }
    }
}
