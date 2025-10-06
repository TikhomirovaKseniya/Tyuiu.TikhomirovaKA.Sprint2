using Tyuiu.TikhomirovaKA.Sprint2.Task0.V3.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint2.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 42;
            int y = 52;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
