using Tyuiu.BocharovaES.Sprint4.Task0.V4.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 32;
            Assert.AreEqual(wait, res); 

        }
    }
}
