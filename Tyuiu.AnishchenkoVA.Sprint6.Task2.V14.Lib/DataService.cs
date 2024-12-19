using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {

                if (2*i - 0.5 == 0)
                {
                    res[count] = 0;
                }

                double y = 5 - 3* i + ((1 + Math.Sin(i))/(2*i - 0.5));
                res[count] = Math.Round(y, 2);
                count++;
            }
            return res;
        }
    }
}
