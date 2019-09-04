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
    public partial class BookTemplateAdd : BasePage
    {
        //int itemId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!int.TryParse(Request.QueryString["ID"], out itemId))
            //{
            //    Response.Redirect("~/BookTemplateAdd.aspx");
            //}

            if (!IsPostBack)
            {
                DataTable authors = DatabaseHelper.Retrieve(@"
                    select AuthorID, LastName + ', ' + FirstName as Name
                    from Author
                    order by LastName, FirstName
                ");

                AuthorDDL.DataValueField = "AuthorID";
                AuthorDDL.DataTextField = "Name";

                // Add an empty 1st option element.
                AuthorDDL.Items.Add(string.Empty);
                AuthorDDL.AppendDataBoundItems = true;

                AuthorDDL.DataSource = authors;
                AuthorDDL.DataBind();


            }
        }



        protected void Save_Click(object sender, EventArgs e)
        {
            string title = Title1.Text;
            int authorID = int.Parse(AuthorDDL.SelectedValue);
            string isbn = ISBN.Text;


            DatabaseHelper.Insert(
                @"INSERT into BookTemplates (Title, AuthorID, ISBN)
                values (@Title, @AuthorId, @ISBN);",


                new SqlParameter("@Title", title),
                new SqlParameter("@AuthorId", authorID),
                new SqlParameter("@ISBN", isbn)
            );

            Response.Redirect("~/BookTemplateList.aspx");
                
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookTemplateList.asp");
        }
    }
}