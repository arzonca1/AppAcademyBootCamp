using Library.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class BranchEdit : BasePage
    {
        int branchId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!int.TryParse(Request.QueryString["id"], out branchId))
            {
                Response.Redirect("~/BranchList.aspx");
            }

            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    select Name, StreetAddress, Zip
                    from Branch
                    where BranchID = @BranchID
                ", new SqlParameter("@BranchId", branchId));

                if (dt.Rows.Count == 1)
                {
                    Name.Text = dt.Rows[0].Field<string>("Name");
                    Address.Text = dt.Rows[0].Field<string>("StreetAddress");
                    Zip.Text = dt.Rows[0].Field<string>("Zip");
                }
                else
                {
                    Response.Redirect("~/BranchList.aspx");
                }
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string address = Address.Text;
            string zip = Zip.Text;

            DatabaseHelper.Update(@"
                update Branch set
                    Name = @Name,
                    StreetAddress = @Address,
                    Zip = @Zip
                where BranchID = @BranchID
            ",
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address),
                new SqlParameter("@BranchId", branchId),
                new SqlParameter("@Zip", zip));

            Response.Redirect("~/BranchList.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BranchList.aspx");
        }
    }
}