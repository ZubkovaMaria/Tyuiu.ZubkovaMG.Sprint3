using Tyuiu.ZubkovaMG.Sprint3.Task2.V10.Lib;

namespace Tyuiu.ZubkovaMG.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.5;

            Assert.AreEqual(wait, res);
        }
    }
}