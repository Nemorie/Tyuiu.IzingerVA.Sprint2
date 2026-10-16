using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint2.Task2.V23.Lib;

namespace Tyuiu.IzingerVA.Sprint2.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
