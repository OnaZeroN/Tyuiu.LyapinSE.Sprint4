using Tyuiu.LyapinSE.Sprint4.Task6.V4.Lib;

namespace Tyuiu.LyapinSE.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new();

            string[] array = ["Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара"];
            string[] expected = ["Москва", "Самара"];

            CollectionAssert.AreEqual(expected, ds.Calculate(array));
        }
    }
}
