using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BocharovaES.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int res = 1;
            for (int i =0; i <= array.Length-1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res *= array[i];
                }
            }
            return res;
        }
    }
}
