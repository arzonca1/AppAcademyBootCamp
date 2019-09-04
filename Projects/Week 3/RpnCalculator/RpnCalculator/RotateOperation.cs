using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class RotateOperation : IOperation
    {
        public void Perform(Stack<decimal> numberstack)
        {
            if (numberstack.Count < 3) return;
            decimal a = numberstack.Pop();
            decimal b = numberstack.Pop();
            decimal c = numberstack.Pop();
            numberstack.Push(a);
            numberstack.Push(b);
            numberstack.Push(c);
        }
    }
}