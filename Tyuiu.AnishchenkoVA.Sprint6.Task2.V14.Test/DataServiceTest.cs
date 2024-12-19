using Tyuiu.AnishchenkoVA.Sprint6.Task2.V14.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            int len = end - start + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 19.81;
            wait[1] = 16.79;
            wait[2] = 13.87;
            wait[3] = 10.98;
            wait[4] = 7.94;
            wait[5] = 3.00;
            wait[6] = 3.23;
            wait[7] = -0.45;
            wait[8] = -3.79;
            wait[9] = -6.97;
            wait[10] = -10.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}