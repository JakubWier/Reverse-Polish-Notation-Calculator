using Calculator;

namespace UnaryOperations
{
    abstract class UnaryOperation : IOperation
    {
        protected IOperation a;
        protected double result;
        public UnaryOperation(IOperation a) { this.a = a;}

        public abstract ref double GetNumber { get; }

        public override string ToString()
        {
            return result.ToString();
        }
    }
}
