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
    public partial class BookAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!int.TryParse(Request.QueryString["ID"], out itemId))
            //{
            //    Response.Redirect("~/BookTemplateAdd.aspx");
            //}

            if (!IsPostBack)
            {
                DataTable books = DatabaseHelper.Retrieve(@"
                    select BookTemplateID, Title
                    from BookTemplates
                    order by Title
                ");

                DataTable branches = DatabaseHelper.Retrieve(@"
                    select BranchID, Name
                    from Branch
                    order by Name");

                BookDDL.DataValueField = "BookTemplateID";
                BookDDL.DataTextField = "Title";

                // Add an empty 1st option element.
                BookDDL.Items.Add(string.Empty);
                BookDDL.AppendDataBoundItems = true;

                BookDDL.DataSource = books;
                BookDDL.DataBind();

                BranchDDL.DataValueField = "BranchID";
                BranchDDL.DataTextField = "Name";

                BranchDDL.Items.Add(string.Empty);
                BranchDDL.AppendDataBoundItems = true;

                BranchDDL.DataSource = branches;
                BranchDDL.DataBind(); 

            }
        }



        protected void Save_Click(object sender, EventArgs e)
        {


            int booktemplateID = int.Parse(BookDDL.SelectedValue);
            int branchID = int.Parse(BranchDDL.SelectedValue);
            int status = 1; //By default any added book should be available 


            DatabaseHelper.Insert(
                @"INSERT into Book (BookTemplateID, BranchID, StatusID)
                values (@BookTemplateID, @BranchID, @StatusID);",


                new SqlParameter("@BookTemplateID", booktemplateID),
                new SqlParameter("@BranchID", branchID),
                new SqlParameter("@StatusID", status)
            );

            Response.Redirect("~/BookList.aspx");

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookList.asp");
        }
    }
}
