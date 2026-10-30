using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IzingerVA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.IzingerVA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDayLeapYear()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 3;
            int n = 1;
            string wait = "29.02.2024";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayNewYear()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 1;
            string wait = "31.12.2023";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayRegular()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 10;
            int n = 15;
            string wait = "14.10.2024";
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
