using Tyuiu.LyapinSE.Sprint4.Task2.V18.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new();

            int[] array = [7, 6, 9, 8, 9, 7, 4];

            Assert.AreEqual(192, ds.Calculate(array));
        }
    }
}
