using System;
using System.Collections.Generic;
using System.Text;

namespace WDP_Zagadnienia
{
    class ReversePolishNotation
    {
        Stack<IOperation> stack;
        public double GetResult
        {
            get
            {
                try
                {
                    if (stack.Count == 0)
                        throw new InvalidOperationException("Stack is empty");
                    return stack.Peek().GetNumber;
                }
                catch (DivideByZeroException divEx)
                {
                    throw divEx;
                }
            }
        }

        public ReversePolishNotation()
        {
            stack = new Stack<IOperation>();
        }

        public void Push(int number)
        {
            stack.Push(new Number(number));
        }

        public bool TryPush(char symbol)
        {
            try
            {
                IOperation operation = symbol switch
                {
                    '+' => new Sum(stack.Pop(), stack.Pop()),
                    '-' => new Subtraction(stack.Pop(), stack.Pop()),
                    '*' => new Multiplication(stack.Pop(), stack.Pop()),
                    '/' => new Division(stack.Pop(), stack.Pop()),
                    ':' => new Division(stack.Pop(), stack.Pop()),
                    '^' => new PowerOfTwo(stack.Pop()),
                    _ => null
                };
                if (operation is null)
                    return false;
                stack.Push(operation);
            } catch
            {
                return false;
            }
            return true;
        }

        public IOperation Pop()
        {
            return stack.Pop();
        }

        public void Clear()
        {
            stack.Clear();
        }

        public override string ToString()
        {
            try {
                return GetResult.ToString();
            }
            catch (InvalidOperationException invEx)
            {
                Console.WriteLine("InvalidOperationException: " + invEx.Message);
            }
            catch (DivideByZeroException divEx)
            {
                Console.WriteLine("DivideByZeroException: " + divEx.Message);
            }
            catch
            {
                return "";
            }
            return "";
        }

    }
}
