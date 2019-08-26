using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class CosOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return (decimal)Math.Cos((double)operand);
        }
    }
}