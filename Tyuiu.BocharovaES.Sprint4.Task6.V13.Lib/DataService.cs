using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BocharovaES.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(s => s.Length > 4);
            return count;
        }
    }
}
