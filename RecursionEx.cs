using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursionsDemo2020
{
    public class RecursionEx
    {

        public void PrintHello()
        {
            Console.WriteLine("Hello");
            PrintHello();
        }

        public void PrintHello(int antalKald)
        {
            if (antalKald > 0)
            {
                Console.WriteLine("Hello");
                PrintHello(antalKald - 1);
            }
            
        }


        public int AddNumbersIterativt(int number)
        {
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum = sum + i;
            }

            return sum;
        }


        public int AddNumbersRekursivt(int number)
        {
            
            if (number > 0)
            { 
                return  number + AddNumbersRekursivt(number - 1);
            }

            return 0;
        }

        public int Factorial(int number)
        {
            //if (number > 0)
            //{
            //    return number * Factorial(number - 1);
            //}
            //return 1; 

            return (number > 0) ? number * Factorial(number - 1) : 1;
        }

        //public int FactorialIterativt(int number)
        //{
        // Implementer denne selv
        //}

        public int Fibonacci(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }

            //return (n < 3) ? 1 : (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        //public int FibonacciIterativt(int number)
        //{
        // Implementer denne selv
        //}

    }
}
