using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashutosh.Nayak.Day3.Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Value:");
            int num=int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    if (num == 1)
                    {
                        Console.WriteLine("Right Number");
                    }
                    break;
                case 2:
                    if (num == 2)
                    {
                        Console.WriteLine("Right Number");
                    }
                    break;
                case 3:
                    if (num == 3)
                    {
                        Console.WriteLine("Right Number");
                    }
                    break;
                case 4:
                    if (num == 4)
                    {
                        Console.WriteLine("Right Number");
                    }
                    break;
                case 5:
                    if (num == 5)
                    {
                        Console.WriteLine("Right Number");
                    }
                    break;
                 default:
                    { 
                        Console.WriteLine("Wrong Number");
                    }
                    break;
            }
        }
    }
}
