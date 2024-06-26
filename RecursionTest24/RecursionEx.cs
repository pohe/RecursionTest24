﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTest24
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

        public void PrintHelloItWhile(int antalKald)
        {
            while (antalKald > 0)
            {
                Console.WriteLine("Hello");
                antalKald--;
            }
        }

        public void PrintHelloItFor(int antalKald)
        {
            for (int i = 0; i < antalKald; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        //Finder summen fra 0 og op til og med number
        public int AddNumbersIterativt(int number)
        {
            int total = 0;
            //for(int i = 1;i <= number;i++)
            //{
            //    total += i; //total = total +i;
            //}
            int currentNumber = 1;
            while (number >= currentNumber)
            {
                total += currentNumber;
                currentNumber++;
            }
            return total;
        }

        public int AddNumbersRecursive(int number)
        {
            if (number>0)
            {
                return number + AddNumbersRecursive(number - 1);
            }
            return 0;
        }


        public int Factorial(int number)
        {
            if(number>=1)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }

        public int FactorialIterativ(int number)
        {
            return 0;
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
        }

        public int FibonacciIterativt(int n)
        {
            return 0;
        }


        //Flyt et tårn på n skier fra A til C via B
        public void TowersOfHanoi(string pegA, string pegB, string pegC, int n)
        {
            if (n > 0)
            {
                
                TowersOfHanoi(pegA, pegC, pegB, n - 1);
                Console.WriteLine("Move disk " + n + ": " + pegA + "->" + pegC);
                TowersOfHanoi(pegB, pegA, pegC, n - 1);
            }
        }

    }
}
