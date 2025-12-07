using Tyuiu.PrilukovDA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.PrilukovDA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(30, ds.Calculate(3, 4, "695847142536"));
        }
    }
}
