using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class AddOperation : AbstractTwoOperandOperation
    {
        public override decimal Calculate(decimal l, decimal r)
        {
            return l + r;
        }
    }
}