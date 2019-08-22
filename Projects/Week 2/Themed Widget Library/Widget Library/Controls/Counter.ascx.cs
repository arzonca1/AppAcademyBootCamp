using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Widget_Library.Controls
{
    public partial class Counter : System.Web.UI.UserControl
    {
        private const string CountViewStateKey = "Count";

        protected int Count
        {
            get
            {
                object viewStateCount = ViewState[CountViewStateKey];
                if (viewStateCount != null)
                {
                    return (int)viewStateCount;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState[CountViewStateKey] = value;
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Value.Text = Count.ToString();
        }

        protected void Plus_Click(object sender, EventArgs e)
        {
            Count++;
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            Count--;
        }
    }
}