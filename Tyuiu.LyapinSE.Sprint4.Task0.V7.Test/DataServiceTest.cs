using Tyuiu.LyapinSE.Sprint4.Task0.V7.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultOddArrEl()
        {
            DataService ds = new();

            int[] array = [9, 8, 7, 9, 5, 4, 3, 2, 3, 7];

            Assert.AreEqual(178_605, ds.GetMultOddArrEl(array));
        }
    }
}
