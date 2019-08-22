using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Widget_Library.Controls
{
    public partial class Font_Preview : System.Web.UI.UserControl
    {
        private List<string> fonts = new List<string>
        {
            "Arial",
            "Helvetica",
            "Times New Roman",
            "Courier",
            "Verdana",
            "Georgia",
            "Palatino",
            "Garamond",
            "Bookman",
            "Comic Sans MS",
            "Trebuchet MS",
            "Arial Black",
            "Impact",
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FontsDDL.DataSource = fonts;
                FontsDDL.DataBind();
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            LoremIpsum.Font.Name = FontsDDL.SelectedValue;
        }
    }
}