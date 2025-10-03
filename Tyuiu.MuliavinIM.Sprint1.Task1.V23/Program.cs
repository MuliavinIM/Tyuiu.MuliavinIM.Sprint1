using Tyuiu.MuliavinIM.Sprint1.Task1.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Мулявин И. М. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя                  *");
        Console.WriteLine("* исходные данные, вычисляет результат по формуле (x*Pi)/(2*a)            *");
        Console.WriteLine("* и печатает его на экране.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, a;

        Console.WriteLine("Введите значение A:");
        a = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());

       

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(a, x));

        Console.ReadLine();

    }
}