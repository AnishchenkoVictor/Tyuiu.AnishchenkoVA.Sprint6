using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnishchenkoVA.Sprint6.Task1.V15.Lib
{
    public class DataService : ISprint6Task1V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {

                if (i - 0.7 == 0)
                {
                    res[count] = 0;
                }

                double y = ((Math.Cos(i)) / (i - 0.7)) - Math.Sin(i) * 12 * i + 2;
                res[count] = Math.Round(y, 2);
                count++;
            }
            return res;
        }
    }
}
