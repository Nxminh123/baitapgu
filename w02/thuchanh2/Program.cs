
﻿using System;

namespace TinhCanNang
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Nhap chieu cao can tinh:");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang can tinh:");
            double weight = float.Parse(Console.ReadLine());

            double BMI = weight/(height*2);
            BMI = Math.Round(BMI, 1);

             Console.Write("BMI: "+ BMI);

            if(BMI <18.5)
            
        
                Console.WriteLine("Suy dinh duong:");
                

            
                else if(BMI < 25)
                
                    Console.WriteLine("Can nang trung binh");
                    
                
                else if(BMI < 30)
                
                    Console.WriteLine("Thua can!");
                   
                
                 else
                    
                        Console.WriteLine("Beo phi!");
                    




        }

    }
}