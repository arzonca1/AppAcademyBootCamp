using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public abstract class AbstractOneOperandOperator : IOperation
    {
        public abstract decimal Calculate(decimal operand);

        public void Perform(Stack<decimal> numberstack)
        {
            if (numberstack.Count < 1) return;
            numberstack.Push(Calculate(numberstack.Pop()));
        }

    }
}