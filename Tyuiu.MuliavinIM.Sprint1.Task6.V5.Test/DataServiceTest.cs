using Tyuiu.MuliavinIM.Sprint1.Task6.V5.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strtest = "казак идёт домой";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strtest);
            string wait = "казак";
            Assert.AreNotEqual(wait, res);
        }
    }
}
