using Tyuiu.MuliavinIM.Sprint1.Task3.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Мулявин И. М. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
        Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a, b, c;

        Console.WriteLine("Сторона A прямоугольника:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Сторона B прямоугольника:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите сторону C квадрата:");
        c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.HowManySquares(a, b, c);
        Console.WriteLine($"Количество квадратов = {result:F3}");

        Console.ReadLine();
    }
}