using Tyuiu.BocharovaES.Sprint4.Task0.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы(статический ввод)                              *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
        Console.WriteLine("* четных элементов массива.  {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

        Console.WriteLine("Исходный массив");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение четных элементов массива = " + ds.GetMultEvenArrEl(numsArray));
        Console.ReadKey();
    }
}