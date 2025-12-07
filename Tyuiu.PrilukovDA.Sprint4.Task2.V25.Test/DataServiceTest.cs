using Tyuiu.PrilukovDA.Sprint4.Task2.V25.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 4, 6, 8, 4, 5, 6, 9, 8, 7, 4, 6 };
            DataService ds  = new DataService();
            Assert.AreEqual(884736, ds.Calculate(array));
        }
    }
}
