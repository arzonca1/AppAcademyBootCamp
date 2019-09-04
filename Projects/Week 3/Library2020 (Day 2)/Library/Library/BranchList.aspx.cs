using Library.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class BranchList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    select BranchID, Name, StreetAddress, Zip
                    from Branch
                    order by Name
                ");

                Branches.DataSource = dt.Rows;
                Branches.DataBind();
            }
        }
    }
}