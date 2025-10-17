using Tyuiu.MuliavinIM.Sprint1.Task7.V1.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 2;
            double c = 3;
            double wait = 0.25;
            double res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
