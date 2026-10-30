using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.IzingerVA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("Туз треф", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("Король червей", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(12, 1));
        }
    }
}
