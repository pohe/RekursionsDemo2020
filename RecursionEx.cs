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

        public void PrintHelloIterativ(int antalKald)
        {
            for (int i = 0; i < antalKald; i++)
            {
                Console.WriteLine("Hello");
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
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            return 1;

            //return (number > 1) ? number * Factorial(number - 1) : 1;
        }

        public int FactorialIterativt(int number)
        {
            //Implementer denne selv
            int res = 1;
            for (int i = 1; i <= number; i++)
                res = res * i;
            return res;
        }

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

        public int FibonacciIterativt(int number)
        {
            //Implementer denne selv
            int sum = 0, p1= 1, p2= 1;

            if (number <= 0)
                sum = 0;
            else if (number < 3)
                sum = 1;
            else
            {
                for (int i = 2; i < number; i++)
                {
                    sum = p1 + p2;
                    p2 = p1;
                    p1 = sum; 
                }
            }
            return sum;

        }


        //txt aksel    l e s k a
        public void ReverseStringIterativ(string txt)
        {
            for (int i = txt.Length-1 ; i >=0  ; i-- )
            {
                //string t = txt.Substring(i, 1);

                Console.Write(txt[i] + " ");
            }
        }


        //aksel   l e s k a
        public void ReverseStringRekursivt(string txt)
        {
            if (txt.Length < 2)
            {
                Console.Write(txt.Substring(0, 1) + " ");
            }
            else
            {
                string firstLetter = txt.Substring(0, 1);
                   
                ReverseStringRekursivt(txt.Substring(1, txt.Length - 1));

                Console.Write(firstLetter + " ");
            }
        }


        public string ReverseStringRekursivttxt(string txt)
        {
            if (txt.Length < 2)
            {
                return txt.Substring(0, 1) + " ";
            }
            else
            {
                string firstLetter = txt.Substring(0, 1);

                return ReverseStringRekursivttxt(txt.Substring(1, txt.Length - 1)) + firstLetter + " ";

            }
        }


        public void FindFiler(string sti)
        {
            var filer = System.IO.Directory.GetFiles(sti);
            foreach (var fil in filer)
                Console.WriteLine(fil);
            var mapper = System.IO.Directory.GetDirectories(sti);
            foreach (var mappe in mapper)
                FindFiler(mappe);
        }

        public Node DanTræ()
        {
            Node n = new Node(2);
            n.VenstreNode = new Node(7);
            n.HøjreNode = new Node(5);
            n.VenstreNode.VenstreNode = new Node(2);
            n.VenstreNode.HøjreNode = new Node(6);
            n.VenstreNode.HøjreNode.VenstreNode = new Node(5);
            n.VenstreNode.HøjreNode.HøjreNode = new Node(11);
            n.HøjreNode.HøjreNode = new Node(9);
            n.HøjreNode.HøjreNode.VenstreNode = new Node(4);
            return n;
        }
        public void PrintTal(Node mor)
        {
            if (mor.VenstreNode != null)
                PrintTal(mor.VenstreNode);
            Console.WriteLine(mor.Tal);
            if (mor.HøjreNode != null)
                PrintTal(mor.HøjreNode);
        }


        public class Node
        {
            public int Tal { get; set; }
            public Node HøjreNode { get; set; }
            public Node VenstreNode { get; set; }

            public Node(int tal)
            {
                Tal = tal;
            }
        }

        //Flyt et tårn på n skiver fra A til C via B
        public void TowersOfHanoi(string pegA, string pegB, string pegC, int n)
        {
            if (n > 0)
            {
                //flyt et tårn på N-1 fra A til B via C
                TowersOfHanoi(pegA, pegC, pegB, n - 1);
                //flyt skiven n fra A til c
                Console.WriteLine($"Flyt skive {n} fra {pegA} til {pegC}");
                //flyt  et tårn på N-1 fra B til C via A
                TowersOfHanoi(pegB, pegA, pegC, n - 1);
            }

        }

        

    }

}

