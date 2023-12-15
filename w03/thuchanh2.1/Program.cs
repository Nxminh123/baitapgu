using System;
using System.Collections;
namespace SystemTime;
class Program

{
    static void Main (string []args)
    {
        int number;
        Console.WriteLine("Nhap so muon kiem tra:");

        number = Int32.Parse(Console.ReadLine());

        if(number < 2)
    
            Console.WriteLine( number + "Khong la SNT:");

            else
            {
                int i =2;
                bool check = true;

                while(i <= Math.Sqrt(number))
                {
                    if(number%i ==0)
                    {
                        check = false;
                        break;

                    }
                    i++;

                }
                if(check)
                {
                    Console.WriteLine(number +"La SNT!");

                }
                else
                {
                    Console.WriteLine(number +"Ko la SNT!");

                }

            }



        


    }
}
