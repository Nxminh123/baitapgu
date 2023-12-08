using System;
namespace SystemTime;
class Program
    

{
   static void Main(string[] args)
    {
        float tienViet;
        float tienDo = 23000;
        Console.Write("Ban can doi bao nhieu $: ");
    tienDo = float.Parse(Console.ReadLine());
    float doiTien = tienDo*23000;
    Console.WriteLine("So tien ban nhan duoc la:" + doiTien + "vnđ");


    }
}