using System;

namespace Calculator
{
    class CalculatorRPN
    {

        static void Main()
        {
            ReversePolishNotation notation;
            WriteGuide();

            for (; ; )
            {
                string[] commandLineArgs = Console.ReadLine().Split();
                Console.Clear();
                WriteGuide();
                notation = ParseArgumentsIntoNotation(commandLineArgs);
                Console.WriteLine(notation + "\n");
                notation.Clear();
            }

        }

        public static void WriteGuide()
        {
            Console.WriteLine("-------------- Reverse Polish Notation Calculator -------------------");
            Console.WriteLine("Supported operation symbols");
            Console.WriteLine("Sum & subtraction: +, -");
            Console.WriteLine("Multiplication & division: *, /, :");
            Console.WriteLine("Power of two: ^");
            Console.WriteLine("Example input: 6 3 + 9 / 12 * ^");
            Console.WriteLine("Result: 144");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Input your operation in Reverse Polish Notation to get result.");
            Console.WriteLine();
        }

        public static ReversePolishNotation ParseArgumentsIntoNotation(string[] args)
        {
            ReversePolishNotation notation = new ReversePolishNotation();

            if (args == null)
                return notation;

            foreach (string command in args)
                if (int.TryParse(command, out int number))
                {
                    notation.Push(number);
                }
                else if (char.TryParse(command, out char symbol))
                {
                    notation.TryPush(symbol);
                }

            return notation;
        }
    }

}