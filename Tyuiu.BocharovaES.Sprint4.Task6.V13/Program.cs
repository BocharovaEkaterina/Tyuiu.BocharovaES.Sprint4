using Tyuiu.BocharovaES.Sprint4.Task6.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан строковый массив данных [Ford, Toyota, Honda, Chevrolet, Mercedes,  *");
        Console.WriteLine("* BMW, Audi] используя класс Array подсчитайте количество элементов,      *");
        Console.WriteLine("* длина которых больше 4.                                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        var carmark = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
        Console.WriteLine("Исходный массив");
        for(int i =0; i <= carmark.Length-1; i++)
        {
            Console.WriteLine(carmark[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("количество элементов, длина которых больше 4:");
        int nums = ds.Calculate(carmark);
        Console.WriteLine(nums);
        Console.ReadKey();
    }
}