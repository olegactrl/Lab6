namespace Lab6._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a = 5.5, b = 6.3;
            Console.WriteLine($"numbers: {MathOperations.Add(a, b)}");

            double[] arrayA = { 5.5, 5.5, 5.5 };
            double[] arrayB = { 6.3, 6.3, 6.3 };
            Console.WriteLine($"arrays: {string.Join(", ", MathOperations.Add(arrayA, arrayB))}");

            double[,] matrixA = { { 5.5, 5.5 }, { 5.5, 5.5 } };
            double[,] matrixB = { { 6.3, 6.3 }, { 6.3, 6.3 } };
            double[,] resultMatrix = MathOperations.Add(matrixA, matrixB);

            Console.WriteLine("matrices:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write($"{resultMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}