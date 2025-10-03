using Tyuiu.MuliavinIM.Sprint1.Task3.V18.Lib;

namespace Tyuiu.MuliavinIM.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 5;
            double b = 5;
            double c = 2;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(4, res);


        }
    }
}
