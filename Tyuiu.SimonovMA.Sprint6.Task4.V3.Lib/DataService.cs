using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double x_D = Convert.ToDouble(x);
                double f_x = Math.Round((3.0 * x_D - 1.5) / (Math.Sin(x_D) - 3.0 + x_D) + 2.0, 2);
                result[count] = f_x;
                count++;
            }

            return result;
        }
    }
}
