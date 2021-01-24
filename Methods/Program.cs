using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add1();
            Add1();
            Add1();
            Add1();
            var result1 = Add2(2, 5);
            Console.WriteLine(result1);
            var result2 = Add2(2);
            Console.WriteLine(result2);
            int number1 = 20;
            int number2;
            var result3 = Add3(ref number1, out number2);
            Console.WriteLine(result3);

            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2,5,3));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            
        }

        static void Add1()
        {
            Console.WriteLine("Added.");
        }

        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, out int number2)
        {
            number1 = 30;
            number2 = 50;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
