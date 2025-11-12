using Tyuiu.BocharovaES.Sprint4.Task7.V9.Lib;
namespace Tyuiu.BocharovaES.Sprint4.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx= new int[n,m];
            string str = "864299753";
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
