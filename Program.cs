using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursionsDemo2020
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursionEx r = new RecursionEx();

            //r.PrintHello();
            //r.PrintHello(5);
            Console.WriteLine($"Add numbers up to 5 iterativt {r.AddNumbersIterativt(5)}");

            Console.WriteLine($"Add numbers up to 5 rekursivt {r.AddNumbersRekursivt(5)}");

            Console.WriteLine($"Fakultet rekursivt af 5  {r.Factorial(5)}");

            Console.WriteLine($"Fibonacci af 7 {r.Fibonacci(7)}");
            Console.ReadLine();
        }
    }
}
