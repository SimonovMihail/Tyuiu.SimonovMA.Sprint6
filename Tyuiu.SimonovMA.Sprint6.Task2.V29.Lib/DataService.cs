using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double x_D = Convert.ToDouble(x);
                double f_x = Math.Round((2.0 * Math.Cos(x_D) + 2.0) / (2.0 * x_D - 1.0) + Math.Cos(x_D) - 5.0 * x_D + 3.0, 2);
                result[count] = f_x;
                count++;
            }

            return result;
        }
    }
}
