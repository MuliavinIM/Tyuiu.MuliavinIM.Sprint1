using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double discriminant = b * b + 4 * a * c;
            double numerator = b + Math.Sqrt(discriminant);
            double denominator = 2 * a;
            double p1 = numerator / denominator;
            double p2 = Math.Pow(a, 3) * c;
            double p3 = Math.Pow(b, -2);

            double result = p1 - p2 + p3;
            return Math.Round(result, 3);
        }
    }
}
