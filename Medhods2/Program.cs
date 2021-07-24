using System;
using System.Linq;

namespace Medhods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            var result = Add2(20);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(out number1, number2);

            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(10,10));
            Console.WriteLine(Multiply(10, 10,10));

            Console.WriteLine(add4(10, 10, 10, 10, 10));


        }
    
        static void Add()
        {
            Console.WriteLine("added!!!");
        }
        static int Add2(int number1=20,int number2=30)
        {
           int result= number1 + number2;
            return result;
        }
        

        static int Add3(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        static int add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }   
}
