using Tyuiu.BocharovaES.Sprint4.Task3.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 4, 4, 7, 8, 9 },
                                       { 9, 5, 9, 7, 8 }, 
                                       { 7, 4, 9, 4, 6 }, 
                                       { 4, 4, 7, 4, 4 }, 
                                       { 4, 5, 8, 6, 7 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int colums = mtrx.Length / rows;

        Console.Title = "Спринт #4 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы.(статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Найдите максимальный     *");
        Console.WriteLine("* элемент в первой строке массива.                                        *");
        Console.WriteLine("* 4, 4, 7, 8, 9                                                           *");
        Console.WriteLine("* 9, 5, 9, 7, 8                                                           *");
        Console.WriteLine("* 7, 4, 9, 4, 6                                                           *");
        Console.WriteLine("* 4, 4, 7, 4, 4                                                           *");
        Console.WriteLine("* 4, 5, 8, 6, 7                                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        
        Console.WriteLine("Массив: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }

            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mtrx);

        Console.WriteLine("Максимальный элемент в первой строке массива = " + res);
        Console.ReadKey();
    }
}