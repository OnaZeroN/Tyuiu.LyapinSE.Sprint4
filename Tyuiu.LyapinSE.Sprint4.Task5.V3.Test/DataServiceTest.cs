using Tyuiu.LyapinSE.Sprint4.Task5.V3.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new();
            int[,] matrix = {
                { -5, 2, 1, -4, 3 },
                { -2, 4, -3, 1, 3 },
                { 2, 4, -3, -2, 1 },
                { -1, -4, 2, -5, 3 },
                {  4, 4, -2, 1, 3 } 
            };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { 
                {0, 2, 1, 0, 3},
                {0, 4, 0, 1, 3},
                {2, 4, 0, 0, 1},
                {0, 0, 2, 0, 3},
                {4, 4, 0, 1, 3} 
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
