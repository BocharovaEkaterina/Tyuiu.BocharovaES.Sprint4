using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BocharovaES.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int x = 0;
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colums; j++)
                {
                    if (i == 1 && array[i, j] > x)
                    {
                        x = array[i, j];
                    }

                }
            return x;
        }
    }
}
