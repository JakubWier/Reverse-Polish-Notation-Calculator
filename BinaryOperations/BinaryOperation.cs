using Calculator;

namespace BinaryOperations
{
    abstract class BinaryOperation : IOperation
    {
        protected IOperation a;
        protected IOperation b;
        protected double result;
        public BinaryOperation(IOperation a, IOperation b) { this.a = a; this.b = b; }

        public abstract ref double GetNumber { get; }

        public override string ToString()
        {
            return result.ToString();
        }
    }
}
