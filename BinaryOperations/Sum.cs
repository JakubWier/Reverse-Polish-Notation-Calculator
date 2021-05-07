using Calculator;

namespace BinaryOperations
{
    class Sum : BinaryOperation
    {
        public Sum(IOperation a, IOperation b) : base(a, b) { }
        public override ref double GetNumber
        {
            get
            {
                result = b.GetNumber + a.GetNumber;
                System.Console.WriteLine(b + " + " + a + " = " + result);
                return ref result;
            }
        }
    }
}
