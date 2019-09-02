using Library.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class BranchAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string address = Address.Text;
            string zip = zipcode.Text;

            int? id = DatabaseHelper.Insert(@"
                insert into Branch (Name, StreetAddress, Zip)
                values (@Name, @StreetAddress, @Zip);
            ",
            new SqlParameter("@Name", name),
            new SqlParameter("@StreetAddress", address),
            new SqlParameter("@Zip", zip));

            Response.Redirect("~/BranchList.aspx");
        }
    }
}