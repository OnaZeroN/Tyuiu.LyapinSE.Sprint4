using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LyapinSE.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());
                }
            }

            int sum = 0;
            foreach (int x in matrix)
            {
                if (x % 2 == 0)
                    sum += x;
            }
            return sum;
        }
    }
}
