using Tyuiu.AnishchenkoVA.Sprint6.Task1.V15.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task1.V15.Test
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

            wait[0] = 59.49;
            wait[1] = 38.47;
            wait[2] = -2.81;
            wait[3] = -19.67;
            wait[4] = -8.42;
            wait[5] = 0.57;
            wait[6] = -6.30;
            wait[7] = -20.14;
            wait[8] = -3.51;
            wait[9] = 38.13;
            wait[10] = 59.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}