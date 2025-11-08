using Tyuiu.BocharovaES.Sprint4.Task1.V20.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 0, 4, 7, 5, 3, 9, 2, 7, 0 };
            int wait =31;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
