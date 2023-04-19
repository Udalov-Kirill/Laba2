namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static double Input_A()
        {

            Console.WriteLine("число А = ");
            double number_A = Convert.ToDouble(Console.ReadLine());

            return number_A;

            Console.WriteLine("число В = ");
            double number_B = Convert.ToDouble(Console.ReadLine());

            return number_B;
        }
        static void Add(double number1, double number2)
        {
            double sum = 0;
            sum = number1 + number2;
            Console.WriteLine("Сумма чисел = " + sum);
        }
    }
}