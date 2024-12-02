using Tyuiu.SimonovMA.Sprint6.Task2.V29.Lib;
namespace Tyuiu.SimonovMA.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            DataService ds = new DataService();
            double[] good_array = { 28.05, 22.27, 17.01, 12.35, 7.51, 0, 1.62, -7.03, -12.99, -17.55, -21.43 };
            double[] bad_array = ds.GetMassFunction(-5, 5);

            for (int i = 0; i < good_array.Length; i++)
            {
                Assert.AreEqual(good_array[i], bad_array[i], $"ÁÀÁÀÕ Â ÏÎÇÈÖÈÈ {i}");
            }
        }
    }
}