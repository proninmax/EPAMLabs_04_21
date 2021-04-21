using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation;
            bool stopedGob = true;
            double arg1;
            double arg2;
            double result;
            while(stopedGob)
            {
                Console.WriteLine("Enter first arg");
                arg1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter operation(-,+,*,/)");
                operation = Char.Parse(Console.ReadLine());
                Console.WriteLine("Enter second arg");
                arg2 = double.Parse(Console.ReadLine());
                switch (operation)
                {
                    case  '+':
                        result = arg1 + arg2;
                        break;
                    case '-':
                        result = arg1 - arg2;
                        break;
                    case '/':
                        result = arg1 / arg2;
                        break;
                    case '*':
                        result = arg1 * arg2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        result = double.MinValue;
                        break;
                }
                Console.WriteLine(arg1 + operation.ToString() + arg2 + "=" + result);
                Console.WriteLine("Click 'y' if you want to continue");
                if (Console.ReadLine() != "y")
                {
                    stopedGob = false;
                }
            }
        }
    }
}
