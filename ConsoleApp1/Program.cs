﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;  i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
