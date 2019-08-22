using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandlingExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(Number1.Text) + int.Parse(Number2.Text);
            Trace.Write($"Sum is {sum}.");
            System.Diagnostics.Debug.Assert(sum != 21);

        }
    }
}