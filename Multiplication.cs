namespace WDP_Zagadnienia
{
    class Multiplication : BinaryOperation
    {
        public Multiplication(IOperation a, IOperation b) : base(a, b) { }
        public override ref double GetNumber
        {
            get
            {
                result = b.GetNumber * a.GetNumber;
                System.Console.WriteLine(b + " * " + a + " = " + result);
                return ref result;
            }
        }
    }
}
