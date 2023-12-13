using System;
using System.Collections;
using System.Diagnostics;
namespace SystemTime
{
    class ReadNumber
    {
        static void Main(String[] arg)
        
        {
            Console.WriteLine("Nhap so can doc:");
            int N = int.Parse(Console.ReadLine());

            if(N<10)
            {
                Console.WriteLine("Nhap so nho hon 10");
                switch(N)
                {
                    case 0: Console.WriteLine("Khong");
                    break;
                    case 1: Console.WriteLine("Mot");
                    break;
                    case 2: Console.WriteLine("Hai");
                    break;
                    case 3: Console.WriteLine("Ba");
                    break;

                    case 4: Console.WriteLine("Bon");
                    break;
                    case 5: Console.WriteLine("Nam");
                    break;
                    case 6: Console.WriteLine("Sau");
                    break;
                    case 7: Console.WriteLine("Bay");
                    break;
                    case 8: Console.WriteLine("Tam");
                    break;
                    case 9: Console.WriteLine("Chin");
                    break;

                }
            }
            else if(N<20)
            {
                int hangChuc = (int)N/10;
                int hangDV = (int)N%10;
                switch(hangChuc)
                {
                    case 2: Console.WriteLine("Hai");
                    break;
                    case 3: Console.WriteLine("Ba");
                    break;
                    case 4: Console.WriteLine("Bon");
                    break;
                    case 5: Console.WriteLine("Nam");
                    break;
                    case 6: Console.WriteLine("Sau");
                    break;
                    case 7: Console.WriteLine("Bay");
                    break;
                    case 8: Console.WriteLine("Tam");
                    break;
                    case 9: Console.WriteLine("Chin");
                    break;
                }
                Console.Write("Muoi");
                switch(hangDV)
                {
                    case 1: Console.WriteLine("Mot");
                    break;
                    case 2: Console.WriteLine("Hai");
                    break;
                    case 3: Console.WriteLine("Ba");
                    break;
                    case 4: Console.WriteLine("Bon");
                    break;
                    case 5: Console.WriteLine("Nam");
                    break;
                    case 6: Console.WriteLine("Sau");
                    break;
                    case 7: Console.WriteLine("Bay");
                    break;
                    case 8: Console.WriteLine("Tam");
                    break;
                    case 9: Console.WriteLine("Chin");
                    break;

                }

            }
            else if(N<99)
            {
                    
            }



    
         
         

            
            
        
           
        }
    }
}