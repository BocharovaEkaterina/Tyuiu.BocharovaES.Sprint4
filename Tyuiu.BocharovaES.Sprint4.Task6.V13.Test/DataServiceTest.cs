using Tyuiu.BocharovaES.Sprint4.Task6.V13.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var carmark = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(carmark);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
