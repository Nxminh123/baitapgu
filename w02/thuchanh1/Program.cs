﻿using System;

namespace GiaiPTBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 1");
            Console.WriteLine("Cho phuong trinh 'a * x + b = 0', nhap hang so:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double nghiem = -b / a;
                Console.Write("Phuong trinh co nghiem là:" + nghiem);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.Write("Vo nghiem!");
                }
            }
            Console.ReadLine();
        }
    }
}