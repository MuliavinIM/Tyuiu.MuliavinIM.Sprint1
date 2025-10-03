using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task1.V23.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double a, double x)
        {
            const double PI = 3.14;
            return (x * PI) / (2 * a);
        }
    }
}