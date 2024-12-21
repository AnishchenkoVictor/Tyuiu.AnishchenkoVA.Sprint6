using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = (stopValue - startValue) + 1;
            res = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) - 2 * x) / (3 * x - 1)) + Math.Sin(x) - 3 * x + 2, 2);
                if (3*x - 1 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = y;
                    count++;
                }
            }
            return res;
        }
    }
}
