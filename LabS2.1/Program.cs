using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Your Address :");
            String Address = Console.ReadLine();

            Console.WriteLine("Enter Your Phone :");
            String Phone = Console.ReadLine();

            Console.WriteLine("Your Name Is :"+ name);
            Console.WriteLine("Your Address Is :" + Address);
            Console.WriteLine("Your Phone Is : " + Phone);
        }
    }
}
