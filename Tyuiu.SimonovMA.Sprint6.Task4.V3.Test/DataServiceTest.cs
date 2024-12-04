using Tyuiu.SimonovMA.Sprint6.Task4.V3.Lib;

namespace Tyuiu.SimonovMA.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            DataService ds = new DataService();
            double[] good_array = { 4.34, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97 };
            double[] bad_array = ds.GetMassFunction(-5, 5);

            for (int i = 0; i < good_array.Length; i++)
            {
                Assert.AreEqual(good_array[i], bad_array[i], $"ÁÀÁÀÕ Â ÏÎÇÈÖÈÈ {i}");
            }
        }
    }
}