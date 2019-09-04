using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RpnCalculator
{

    public partial class CalculatorUI : System.Web.UI.Page
    {
        protected Calculator Calculator
        {
            get
            {
                object viewstate = ViewState["Calculator"];
                if (viewstate != null)
                {
                    return (Calculator)viewstate;
                }
                else return null;
            }
            set
            {
                ViewState["Calculator"] = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!IsPostBack)
            {
                Calculator = new Calculator(); 
            }
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            string[] entries = Calculator.GetFourEntries();
            StackViewer.DataSource = entries;
            StackViewer.DataBind();
        }

        protected void HandleEnter(object sender, EventArgs e)
        {
            try
            {
                Calculator.Push(decimal.Parse(NumberInput.Text));
            }
            catch (Exception)
            {

            }
            finally
            {
                NumberInput.Text = "";
            }
        }
        protected void HandleAdd(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Add);
        }
        protected void HandleMinus(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Minus);
        }
        protected void HandleMultiply(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Multiply);
        }
        protected void HandleDivide(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Divide);
        }
        protected void HandleNegate(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Negate);
        }
        protected void HandleDrop(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Drop);
        }

        protected void HandleSquareRoot(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.SquareRoot);
        }

        protected void HandleXtoY(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.XtoY);
        }

        protected void HandleEtoX(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.EtoX);
        }
        protected void HandleOneOverX(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.OneOverX);
        }
        protected void HandleSin(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Sin);
        }
        protected void HandleCos(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Cos);
        }

        protected void HandleClear(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Clear);
        }
        protected void HandleSwap(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Swap);
        }
        protected void HandleRotate(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Rotate);
        }
    }
}