using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double f_x = Math.Round(Math.Sin(x) + ((2.0 * x) / 3.0) - (Math.Cos(x) * (4.0 * x)), 2);
                result[count] = f_x;
                count++;
            }

            return result;
        }
    }
}
