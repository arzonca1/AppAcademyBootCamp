using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    [Serializable]
    public class Calculator
    {
        Stack<decimal> NumberStack;

        public Calculator()
        {
            NumberStack = new Stack<decimal>();
        }
        public void Push(decimal dec)
        {
            NumberStack.Push(dec);
        }



        public string[] GetFourEntries()
        {
            string[] result = new string[4];
            for (int i = 3; i >= 0; i--)
            {
                try
                {
                    result[i] = NumberStack.ElementAt(3 - i).ToString();
                }
                catch (Exception)
                {
                    result[i] = null;
                }
            }
            return result;
        }

        public void PerformOperation(OperationType ot)
        {
            IOperation o = null; 
            switch (ot)
            {
                case OperationType.Add:
                    o = new AddOperation();
                    break;
                case OperationType.Minus:
                    o = new MinusOperation();
                    break;
                case OperationType.Multiply:
                    o = new MultiplyOperation();
                    break;
                case OperationType.Divide:
                    o = new DivideOperation();
                    break;
                case OperationType.Negate:
                    o = new NegateOperation();
                    break;
                case OperationType.Drop:
                    o = new DropOperation();
                    break;
                case OperationType.SquareRoot:
                    o = new SquareRootOperation();
                    break;
                case OperationType.XtoY:
                    o = new XtoYOperation();
                    break;
                case OperationType.EtoX:
                    o = new EtoXOperation();
                    break;
                case OperationType.OneOverX:
                    o = new OneOverXOperation();
                    break;
                case OperationType.Sin:
                    o = new SinOperation();
                    break;
                case OperationType.Cos:
                    o = new CosOperation();
                    break;
                case OperationType.Clear:
                    o = new ClearOperation();
                    break;
                case OperationType.Swap:
                    o = new SwapOperation();
                    break;
                case OperationType.Rotate:
                    o = new RotateOperation();
                    break;
            
            }
            if (o != null) o.Perform(NumberStack);
        }
        

    }
}