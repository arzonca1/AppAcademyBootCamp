using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class EtoXOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return (decimal)Math.Pow(Math.E, (double)operand);
        }
    }
}