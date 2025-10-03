using Tyuiu.MuliavinIM.Sprint1.Task1.V23.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 2.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(0,785, res);
        }
    }
}
