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
    public partial class BookList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(
                    @"select i.BookTemplateID, i.AuthorID, i.Title, i.ISBN, a.FirstName, a.LastName
                    from BookTemplates i
                    join Author a on i.AuthorID = a.AuthorID");

                DataTable td = DatabaseHelper.Retrieve(
                    @"select b.BookID, b.BookTemplateID, b.BranchID, b.BookTemplateID, b.StatusID,
                    a.LastName + ', ' + a.FirstName as Author, bt.Title, bt.ISBN, br.Name as Branch, s.Name as Status
                    from Book b
                    join BookTemplates bt on b.BookTemplateID = bt.BookTemplateID
                    join Author a on bt.AuthorID = a.AuthorID
                    join CirculationStatus s on b.StatusID = s.StatusID
                    join Branch br on b.BranchID = br.BranchID");

                Books.DataSource = td.Rows;
                Books.DataBind();
            }
        }
    }
}
