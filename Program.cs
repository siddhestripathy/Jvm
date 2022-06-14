using System;

namespace Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;
            Console.WriteLine("\t\t\tCONSOLE CALCULATOR!\n");
            Console.WriteLine("\t\t\tEnter the first number:");
            firstnum = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tSelect an Operator:(+,-,*,/,%,^)\n");
            ops = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter the second number:");
            secondnum = Double.Parse(Console.ReadLine());
            if (ops == "+")
            {
                answer = firstnum +  secondnum;
                Console.Write(answer);
            }
            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write(answer);
            }
            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write(answer);
            }
            if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write(answer);
            }
            if (ops == "%")
            {
                answer = firstnum % secondnum;
                Console.Write(answer);
            }
            Console.ReadKey();
        }
    }
}

