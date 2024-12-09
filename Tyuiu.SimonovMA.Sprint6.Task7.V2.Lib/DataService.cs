using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimonovMA.Sprint6.Task7.V2.Lib
{
    public class DataService : ISprint6Task7V2
    {
        public int[,] GetMatrix(string path)
        {
            var lines = File.ReadAllLines(path);

            var matrix = lines
                .Select(line => line.Split(';').Select(int.Parse).ToArray())
                .ToArray();

            for (int j = 0; j < matrix[1].Length; j++)
            {
                if (matrix[1][j] % 2 == 0)
                {
                    matrix[1][j] = 555;
                }
            }

            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[,] resultMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix[i][j];
                }
            }

            return resultMatrix;
        }
    }
}
