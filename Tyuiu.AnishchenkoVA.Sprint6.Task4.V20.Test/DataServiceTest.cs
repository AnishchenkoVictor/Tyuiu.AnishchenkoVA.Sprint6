using Tyuiu.AnishchenkoVA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task4.V20.Test
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

            wait[0] = 17.27;
            wait[1] = 14.08;
            wait[2] = 10.27;
            wait[3] = 6.65;
            wait[4] = 3.87;
            wait[5] = 2.00;
            wait[6] = -0.74;
            wait[7] = -3.71;
            wait[8] = -7.59;
            wait[9] = -11.55;
            wait[10] = -14.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}