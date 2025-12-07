using Tyuiu.PrilukovDA.Sprint4.Task5.V17.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
       {
            { -5, -9, 8, 0, -2 },
            { -4, -9, -8, 3, 1 },
            { 2, 5, 4, -3, -1 },
            { -6, 0, -7, 4, -8 },
            { 1, -2, 3, -4, 2 }
       };

            Assert.AreEqual(13, ds.Calculate(matrix));
        }
    }
}
