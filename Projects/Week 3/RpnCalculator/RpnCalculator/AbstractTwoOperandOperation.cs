using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public abstract class AbstractTwoOperandOperation : IOperation
    {
        public abstract decimal Calculate(decimal l, decimal r);

        public void Perform(Stack<decimal> numberstack)
        {
            if (numberstack.Count < 2) return;
            decimal r = numberstack.Pop();
            decimal l = numberstack.Pop();
            decimal result = Calculate(l, r);
            numberstack.Push(result);
        }
    }
}