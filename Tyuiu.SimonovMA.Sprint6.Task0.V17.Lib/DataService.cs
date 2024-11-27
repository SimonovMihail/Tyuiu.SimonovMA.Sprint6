using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task0.V17.Lib
{
    public class DataService : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            return Math.Round(Math.Exp(x) / Convert.ToDouble(x), 3);
        }
    }
}
