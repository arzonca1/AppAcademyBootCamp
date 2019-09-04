using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class ClearOperation : IOperation
    {
        public void Perform(Stack<decimal> numberstack)
        {
            numberstack.Clear();
        }
    }
}