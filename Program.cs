// C# program to accept user inputs and calculate

using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input for a");
            string A = Console.ReadLine();
            int a = Convert.ToInt32(A);

            Console.WriteLine("Please provide your input for b");
            string B = Console.ReadLine();
            int b = Convert.ToInt32(B);

            Console.WriteLine("Please provide your input for c");
            string C = Console.ReadLine();
            int c = Convert.ToInt32(C);

            int s = (a + b + c) / 3;

            Console.WriteLine("s value is" + s);
        }
    }
}


