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
    public partial class BookEdit : System.Web.UI.Page
    {
        int bookID1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!int.TryParse(Request.QueryString["id"], out bookID1))
            {
                Response.Redirect("~/BookList.aspx");
            }

            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    select b.BookID as BookID, a.LastName + ', ' + a.FirstName as Author,
                    bt.Title as Title, br.Name as Branch
                    from Book b
                    join BookTemplates bt on b.BookTemplateID = bt.BookTemplateID
                    join Author a on bt.AuthorID = a.AuthorID
                    join Branch br on b.BranchID = br.BranchID



                    where BookID = @BookID
                ", new SqlParameter("@BookID", bookID1));

                if (dt.Rows.Count == 1)
                {
                    BookID.Text = dt.Rows[0].Field<int>("BookID").ToString(); ;
                    BookAuthor.Text = dt.Rows[0].Field<string>("Author");
                    BookTitle.Text = dt.Rows[0].Field<string>("Branch");



                    DataTable status = DatabaseHelper.Retrieve(@"
                    select StatusID, Name
                    from CirculationStatus
                    order by StatusID
                ");


                    BookStatusDDL.DataValueField = "StatusID";
                    BookStatusDDL.DataTextField = "Name";

                    // Add an empty 1st option element.
                    BookStatusDDL.Items.Add(string.Empty);
                    BookStatusDDL.AppendDataBoundItems = true;

                    BookStatusDDL.DataSource = status;
                    BookStatusDDL.DataBind();
                }

                else
                {
                    Response.Redirect("~/BookList.aspx");
                }
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {


            int status1 = int.Parse(BookStatusDDL.SelectedValue); 

            DatabaseHelper.Update(@"
                update Book set

                    StatusID = @StatusID
                where BookID = @BookID
            ",
                new SqlParameter("@StatusID", status1),
                new SqlParameter("@BookID", bookID1));

            Response.Redirect("~/BookList.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookList.aspx");
        }
    }
}