﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 4, end = 6, step = 1;
            string outputFile = "OutPutFileTask1.txt";
            for (double x = start; x <= end; x += step)
            {
                double result = 2 * x + 3 * Math.Pow(x, 2) - 34;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                File.AppendAllText(outputFile, $"{result}\n");
                Console.WriteLine($"{result}");
                Console.ReadLine();
            }
        }
    }
}
