using Tyuiu.BocharovaES.Sprint4.Task2.V4.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 3, 3, 5, 4, 6, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 26;
            Assert.AreEqual(wait, res);
        }
    }
}
