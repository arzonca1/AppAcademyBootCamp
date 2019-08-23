using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Widget_Library
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void ThemeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.Theme = ThemeDropDownList.SelectedValue;
        //    Response.Redirect(Request.RawUrl);
        //}

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