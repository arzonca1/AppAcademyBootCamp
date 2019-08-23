using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Widget_Library
{
    public partial class Example_Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPreInit(EventArgs e)
        {
            var master = Master as Site;
            if (master != null && !string.IsNullOrEmpty(master.Theme))
            {
                Theme = master.Theme;
            }

            base.OnPreInit(e);
        }
    }
}