using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint2.Task4.V24.Lib;

namespace Tyuiu.IzingerVA.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -25;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(72.0, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.573, res);
        }
    }
}
