using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //Swap two nibbles in a byte
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x << 4| x >> 4;
            
            Console.WriteLine("Original number {0}, Swapped number {1}",x,y);
        }
    }
}
