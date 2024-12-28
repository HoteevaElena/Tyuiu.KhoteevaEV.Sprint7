using Tyuiu.KhoteevaEV.Sprint7.Project.V5.Lib;
using System.IO;
namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidAmount()
        {
            DataService ds = new DataService();
            string[,] m = { { "1", "Name", "1", "20", "Note" },
                            { "2", "Name", "1", "10", "Note" },
                            { "3", "Name", "1", "28", "Note" },
                            { "4", "Name", "1", "15", "Note" },
                            { "5", "Name", "1", "5", "Note" },
                             { "", "", "", "", "" }};
            var res = ds.Amount(m, 6);
            var wait = 5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidAllCost()
        {
            DataService ds = new DataService();
            string[,] m = { { "1", "Name", "4", "20", "Note" },
                            { "2", "Name", "7", "10", "Note" },
                            { "3", "Name", "13", "28", "Note" },
                            { "4", "Name", "9", "15", "Note" },
                            { "5", "Name", "5", "5", "Note" },
                             { "", "", "", "", "" }};
            var res = ds.AllCost(m, 6);
            var wait = 674;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMaxCost()
        {
            DataService ds = new DataService();
            string[,] m = { { "1", "Name", "4", "20", "Note" },
                            { "2", "Name", "7", "10", "Note" },
                            { "3", "Name", "13", "28", "Note" },
                            { "4", "Name", "9", "15", "Note" },
                            { "5", "Name", "5", "5", "Note" },
                             { "", "", "", "", "" }};
            var res = ds.MaxCost(m, 6);
            var wait = 28;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMinCost()
        {
            DataService ds = new DataService();
            string[,] m = { { "1", "Name", "4", "20", "Note" },
                            { "2", "Name", "7", "10", "Note" },
                            { "3", "Name", "13", "28", "Note" },
                            { "4", "Name", "9", "15", "Note" },
                            { "5", "Name", "5", "5", "Note" },
                             { "", "", "", "", "" }};
            var res = ds.MinCost(m, 6);
            var wait = 5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}