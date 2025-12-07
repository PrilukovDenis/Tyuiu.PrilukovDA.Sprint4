using Tyuiu.PrilukovDA.Sprint4.Task1.V10.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            DataService ds = new DataService();
            Assert.AreEqual(1125, ds.Calculate(arr));
        }
    }
}
