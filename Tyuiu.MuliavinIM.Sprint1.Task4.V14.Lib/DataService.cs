using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            var abs = Math.Abs(x - y);
            var sqrt = Math.Sqrt(7 + abs);
            var pow = 3 * x * Math.Pow(y, 2);
            var res = sqrt / pow;

            return Math.Round(res, 3);
        }
    }
}
