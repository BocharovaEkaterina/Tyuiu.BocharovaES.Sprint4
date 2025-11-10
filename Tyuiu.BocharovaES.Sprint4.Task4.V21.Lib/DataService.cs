using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BocharovaES.Sprint4.Task4.V21.Lib
{
    public class DataService : ISprint4Task4V21
    {
        public int Calculate(int[,] matrix)
        {
            int sumMatrix = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i< rows; i++)
            {
                for (int j=0; j< columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        sumMatrix += matrix[i, j];
                }
            }
            return sumMatrix;
        }
    }
}
