using Tyuiu.PrilukovDA.Sprint4.Task3.V28.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[5, 5]
{
            { 5, 4, 9, 8, 5 },
            { 4, 6, 6, 9, 9 },
            { 9, 8, 4, 8, 8 },
            { 6, 8, 6, 8, 9 },
            { 9, 4, 6, 6, 7 }
};

            DataService ds = new DataService();
            Assert.AreEqual(6, ds.Calculate(array));
        }
    }
}
