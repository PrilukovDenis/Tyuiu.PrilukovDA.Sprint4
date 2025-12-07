using Tyuiu.PrilukovDA.Sprint4.Task6.V11.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            Assert.AreEqual(3, ds.Calculate(array));
        }
    }
}
