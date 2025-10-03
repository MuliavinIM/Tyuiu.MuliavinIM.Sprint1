using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            var b = Math.Sqrt(7 + Math.Abs(x - y));
            var c = 3 * x * Math.Pow(y, 2);
            var result = x / y;
            
            return Math.Round(result, 3);
        }
    }
}
