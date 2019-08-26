using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class SwapOperation : IOperation
    {
        public void Perform(Stack<decimal> numberstack)
        {
            if (numberstack.Count < 2) return;
            decimal a = numberstack.Pop();
            decimal b = numberstack.Pop();
            numberstack.Push(a);
            numberstack.Push(b);
        }
    }
}