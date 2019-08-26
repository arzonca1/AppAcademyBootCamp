using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class XtoYOperation : AbstractTwoOperandOperation
    {
        public override decimal Calculate(decimal l, decimal r)
        {
            return (decimal)Math.Pow((double)l, (double)r);
        }
    }
}