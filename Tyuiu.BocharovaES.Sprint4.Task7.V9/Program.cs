using Tyuiu.BocharovaES.Sprint4.Task7.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проетов по спринту                  *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"864299753\". Преобразуйте ее в      *");
        Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
        Console.WriteLine("*                                                                         *");

        int n = 3;
        int m = 3;
        int[,] mtrx = new int[n, m];
        string str = "864299753";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        int index = 0;


        Console.WriteLine("\nМассив");
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]}\t");
                index++;
            }
            Console.WriteLine();

        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        
        int res = ds.Calculate(n, m, str);
        Console.WriteLine("Количество четных чисел: " + res);
        Console.ReadKey();
    }
}