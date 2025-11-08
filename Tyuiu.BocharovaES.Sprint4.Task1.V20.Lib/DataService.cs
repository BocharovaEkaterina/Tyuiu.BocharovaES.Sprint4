using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BocharovaES.Sprint4.Task1.V20.Lib
{
    public class DataService : ISprint4Task1V20
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for(int i =0; i <= array.Length-1; i++)
            {
                if (array[i]%2 != 0)
                {
                    res += array[i];
                }
            }
            return res;
        }
    }
}
