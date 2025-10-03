using Tyuiu.MuliavinIM.Sprint1.Task5.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Мулявин И. М. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Мулявин Иван Михайлович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
        Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с       *");
        Console.WriteLine("* помощью класса Convert.                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double fahrenheit;

        Console.WriteLine("Введите температуру в градусах Фаренгейта:");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.FahrenheitToСelsius(fahrenheit));

        Console.ReadLine();
    }
}