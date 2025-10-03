using Tyuiu.MuliavinIM.Sprint1.Task4.V14.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
