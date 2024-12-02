using Tyuiu.SimonovMA.Sprint6.Task1.V23.Lib;

namespace Tyuiu.SimonovMA.Sprint6.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckTheArrays()
        {
            DataService ds = new DataService();
            double[] good_array = { 3.3, -12.37, -14.02, -5.57, 0.65, 0, -0.65, 5.57, 14.02, 12.37, -3.3 };
            double[] bad_array = ds.GetMassFunction(-5, 5);

            for (int i = 0; i < good_array.Length; i++)
            {
                Assert.AreEqual(good_array[i], bad_array[i], $"ÁÀÁÀÕ Â ÏÎÇÈÖÈÈ {i}");
            }
        }
    }
}