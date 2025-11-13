using Tyuiu.LyapinSE.Sprint4.Task4.V16.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new();

            int[,] matrix =
            {
                { 6, 5, 6, 7, 3 },
                { 5, 4, 6, 7, 3 },
                { 5, 5, 5, 6, 5 },
                { 6, 5, 4, 4, 3 },
                { 4, 5, 4, 5, 5 }
            };

            int[,] waitMatrix =
            {
                { 1, 5, 1, 7, 3 },
                { 5, 1, 1, 7, 3 },
                { 5, 5, 5, 1, 5 },
                { 1, 5, 1, 1, 3 },
                { 1, 5, 1, 5, 5 }
            };

            CollectionAssert.AreEqual(waitMatrix, ds.Calculate(matrix));
        }
    }
}
