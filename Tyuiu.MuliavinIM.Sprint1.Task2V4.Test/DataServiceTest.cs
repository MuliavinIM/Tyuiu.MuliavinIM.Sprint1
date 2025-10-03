using Tyuiu.MuliavinIM.Sprint1.Task2.V4.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquare(x);
            Assert.AreEqual(4, res);
        }
    }
}
