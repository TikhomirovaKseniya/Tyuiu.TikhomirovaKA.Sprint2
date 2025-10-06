using Tyuiu.TikhomirovaKA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            int value1 = 1;
            int value2 = 12;
            string res = ds.FindCardNameAndValue(value1, value2);
            Assert.AreEqual("Дама пик", res);
        }
    }
}
