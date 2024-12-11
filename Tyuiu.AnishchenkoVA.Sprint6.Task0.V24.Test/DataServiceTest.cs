using Tyuiu.AnishchenkoVA.Sprint6.Task0.V24.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 1024;
            Assert.AreEqual(wait, res);
        }
    }
}