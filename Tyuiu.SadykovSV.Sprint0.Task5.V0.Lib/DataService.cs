namespace Tyuiu.SadykovSV.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
