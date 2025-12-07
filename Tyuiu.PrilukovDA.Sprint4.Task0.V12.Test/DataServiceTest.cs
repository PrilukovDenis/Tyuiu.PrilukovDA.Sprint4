

using Tyuiu.PrilukovDA.Sprint4.Task0.V12.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            DataService ds = new DataService();
            for(int k = 0; k <=9; k++)
            {
                Assert.AreEqual(73728, ds.GetMultEvenArrEl(array));
            }
        }
    }
}
