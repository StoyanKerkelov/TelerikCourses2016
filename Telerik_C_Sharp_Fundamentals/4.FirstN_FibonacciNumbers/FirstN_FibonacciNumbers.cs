﻿using System;

namespace ConsoleInputOutput
{
    public static class FirstN_FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) Console.WriteLine(0);
            else
            {
                long first = 0;
                long second = 1;
                long third = 0;

                Console.Write(first);
                Console.Write(", " + second);
                for (int i = 2; i < n; i++)
                {
                    third = first + second;
                    Console.Write(", " + third);
                    first = second;
                    second = third;
                }
            }
        }
    }
}