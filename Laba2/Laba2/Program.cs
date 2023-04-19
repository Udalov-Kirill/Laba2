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
        }
        static double Input_B()
        { 
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
        static void Sub(double number1, double number2)
        {
            double sub = 0;
            sub = number1 - number2;
            Console.WriteLine("Разность чисел = " + sub);
        }
    }
}