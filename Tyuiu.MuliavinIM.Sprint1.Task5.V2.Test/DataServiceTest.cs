using Tyuiu.MuliavinIM.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 280;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(173, res);
        }
    }
}
