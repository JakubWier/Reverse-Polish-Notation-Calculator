using Calculator;

namespace UnaryOperations
{
    class PowerOfTwo : UnaryOperation
    {
        public PowerOfTwo(IOperation a) : base(a) { }

        public override ref double GetNumber {
            get
            {
                result = a.GetNumber;
                result *= result;
                System.Console.WriteLine(a + "^2 = " + result);
                return ref result;
            }
        }
    }
}
