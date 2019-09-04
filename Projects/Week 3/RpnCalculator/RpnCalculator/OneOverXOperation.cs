using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    public class OneOverXOperation : AbstractOneOperandOperator
    {
        public override decimal Calculate(decimal operand)
        {
            return 1 / operand;
        }
    }
}