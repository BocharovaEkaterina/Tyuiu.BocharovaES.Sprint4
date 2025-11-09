using Tyuiu.BocharovaES.Sprint4.Task2.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы(генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
        Console.WriteLine("* массива.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        int len;

        Console.Write("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(2, 9);
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);

        Console.WriteLine("Сумма нечетных элементов массива = " + res);
        Console.ReadKey();
    }
}