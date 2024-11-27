using Tyuiu.SimonovMA.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SimonovMA.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            Assert.AreEqual(3.695, ds.Calculate(x));
        }
    }
}