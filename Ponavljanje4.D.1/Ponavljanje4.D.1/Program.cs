using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4.D._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            float x, y;

            x = a / b;
            y = a % b;

            Console.WriteLine("A dijelejno s b je "+x+"i ostatak je "+y);
            Console.ReadKey();
        }
    }
}
