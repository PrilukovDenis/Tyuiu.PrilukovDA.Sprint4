using Microsoft.ApplicationInsights;
using Tyuiu.PrilukovDA.Sprint4.Task4.V24.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task4.V24.Test
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
            { 7, 9, 7, 6, 7 },
            { 9, 9, 8, 6, 7 },
            { 8, 6, 5, 6, 7 },
            { 9, 9, 7, 8, 7 },
            { 5, 9, 9, 8, 9 }
};

            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            int[,] truthArr = {
                { 7, 9, 7, 1, 7 },
                { 9, 9, 1, 1, 7 },
                { 1, 1, 5, 1, 7 },
                { 9, 9, 7, 1, 7 },
                { 5, 9, 9, 1, 9 }
            };
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Assert.AreEqual(truthArr[i, j], result[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
