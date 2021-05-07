using Calculator;

namespace BinaryOperations
{
    class Subtraction : BinaryOperation
    {
        public Subtraction(IOperation a, IOperation b) : base(a, b) { }
        public override ref double GetNumber
        {
            get
            {
                result = b.GetNumber - a.GetNumber;
                System.Console.WriteLine(b + " - " + a + " = " + result);
                return ref result;
            }
        }
    }
}
