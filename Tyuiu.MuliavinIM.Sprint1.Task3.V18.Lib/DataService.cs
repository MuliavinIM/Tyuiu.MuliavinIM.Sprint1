using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task3.V18.Lib

{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double countHorizontal = Math.Floor(a / c);
            double countVertical = Math.Floor(b / c);
            double totalCount = countHorizontal * countVertical;

            return Math.Round(totalCount, 3);
        }
    }
}
