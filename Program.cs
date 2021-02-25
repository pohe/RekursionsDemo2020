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
            // r.PrintHello(3);
            //r.PrintHelloIterativ(3);
            //Console.WriteLine($"Add numbers up to 5 iterativt {r.AddNumbersIterativt(5)}");

            //Console.WriteLine($"Add numbers up to 5 rekursivt {r.AddNumbersRekursivt(5)}");

            //Console.WriteLine($"Fakultet rekursivt af 3  {r.Factorial(3)}");
            //Console.WriteLine($"Fakultet iterativt  af 5  {r.FactorialIterativt(5)}");

            //Console.WriteLine(r.ReverseString("Poul"));

            //r.ReverseStringIterativ("aksel");
            //r.ReverseStringRekursivt("aksel");

            string omvendt = r.ReverseStringRekursivttxt("aksel");
            Console.WriteLine(omvendt);
            //Console.WriteLine($"Fibonacci af 6 {r.Fibonacci(6)}");
            //Console.WriteLine($"Fibonacci af 6 {r.FibonacciIterativt(6)}");

            //r.FindFiler(@"C:\Users\EASJ\OneDrive - Zealand Sjællands Erhvervsakademi(1)\Dokumenter\UV\SWC2021F\Programmer\Collections");

            //RecursionEx.Node mor= r.DanTræ();
            //r.PrintTal(mor);

            //string pegA = "pegA";
            //string pegB = "pegB";
            //string pegC = "pegC";


            //r.TowersOfHanoi(pegA, pegB, pegC, 4);

            Console.ReadLine();
        }
    }
}
