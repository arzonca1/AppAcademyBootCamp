using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class NegateOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return operand*-1;
        }
    }
}