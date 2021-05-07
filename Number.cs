namespace WDP_Zagadnienia
{
    class Number : IOperation
    {
        double number;
        public Number(int number)
        {
            this.number = number;
        }
        public ref double GetNumber => ref number;

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
