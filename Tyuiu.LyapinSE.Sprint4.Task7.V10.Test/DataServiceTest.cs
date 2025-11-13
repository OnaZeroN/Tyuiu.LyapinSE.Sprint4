using System.Globalization;
using Tyuiu.LyapinSE.Sprint4.Task7.V10.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new();
            Assert.AreEqual(30, ds.Calculate(3, 4, "695847142536"));
        }
    }
}
