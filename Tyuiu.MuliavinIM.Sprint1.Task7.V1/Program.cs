using Tyuiu.MuliavinIM.Sprint1.Task7.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Мулявин И. М. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                               *");
        Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
        Console.WriteLine("* 3 знаков после запятой.                                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*             (b + sqrt(b^2 + 4ac))                                        *");
        Console.WriteLine(" Формула: z = ---------------------   - a^3 * c + b^(-2)                    ");
        Console.WriteLine("*                     (2a)                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a, b, c;

        Console.WriteLine("Введите значение A:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение B:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение C:");
        c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(a, b, c));


        Console.ReadLine();
    }
}