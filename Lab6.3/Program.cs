namespace Lab6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quaternion q1 = new Quaternion(1, 2, 3, 4);
            Quaternion q2 = new Quaternion(5, 6, 7, 8);

            Quaternion sum = q1 + q2;
            Console.WriteLine($"Sum: {sum.W}, {sum.X}, {sum.Y}, {sum.Z}");

            Quaternion difference = q1 - q2;
            Console.WriteLine($"Difference: {difference.W}, {difference.X}, {difference.Y}, {difference.Z}");

            Quaternion product = q1 * q2;
            Console.WriteLine($"MUltiplication: {product.W}, {product.X}, {product.Y}, {product.Z}");

            double magnitude = q1.Magnitude();
            Console.WriteLine($"Norma: {magnitude}");

            Quaternion conjugate = q1.Conjugate();
            Console.WriteLine($"Conjugate: {conjugate.W}, {conjugate.X}, {conjugate.Y}, {conjugate.Z}");

            try
            {
                Quaternion inverse = q1.Inverse();
                Console.WriteLine($"Inverse: {inverse.W}, {inverse.X}, {inverse.Y}, {inverse.Z}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Are q1 and q2 equal? {q1 == q2}");
            Console.WriteLine($"Are q1 and conjugate of q1 equal? {q1 == q1.Conjugate()}");
        }
    }
}