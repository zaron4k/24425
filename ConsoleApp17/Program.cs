using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation del = new Operation(Add);
            int  result = del.Invoke(4, 5);
            Console.WriteLine(result);
            del = Multiply; 
            result = del(4, 5);
            Console.WriteLine(result);
            del = Minus;
            result = del(100, 88);
            Console.WriteLine(result);
            del = Division;
            result = del(80, 5);
            Console.WriteLine(result);
            Console.Read();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Minus(int x, int y)
        {
            return x - y;
        }
        private static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
