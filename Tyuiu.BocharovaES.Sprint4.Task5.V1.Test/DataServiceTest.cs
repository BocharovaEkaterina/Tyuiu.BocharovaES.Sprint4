using Tyuiu.BocharovaES.Sprint4.Task5.V1.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = { { 2, 5, -5 }, 
                            { -5, 5, 0 },
                            { -7, 5, 4 }};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 1, 1, -5 },
                            { -5, 1, 0 },
                            { -7, 1, 1 }};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
