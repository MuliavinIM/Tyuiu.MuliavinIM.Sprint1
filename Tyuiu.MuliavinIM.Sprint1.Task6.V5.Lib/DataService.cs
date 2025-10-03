using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MuliavinIM.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            var words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var symmetricalWords = words.Where(word => word.SequenceEqual(word.Reverse())).ToArray();
            return string.Join(" ", symmetricalWords);
        }
    }
}
