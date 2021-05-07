using System;
using Calculator;

namespace BinaryOperations
{
    class Division : BinaryOperation
    {
        public Division(IOperation a, IOperation b) : base(a, b) { }
        public override ref double GetNumber
        {
            get
            {
                if (a.ToString() == "0")
                    throw new DivideByZeroException($"Attempted to divine {b} by zero.");
                result = b.GetNumber / a.GetNumber;
                Console.WriteLine(b + " / " + a + " = " + result);
                return ref result;
            }
        }
    }
}
