using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class SinOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return (decimal) Math.Sin((double)operand);
        }
    }
}