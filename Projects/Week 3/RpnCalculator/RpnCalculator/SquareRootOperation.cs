using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class SquareRootOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return (decimal)Math.Pow((double)operand, .5);
        }
    }
}