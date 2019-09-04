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
    public partial class BookTemplateList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(
                    @"select i.BookTemplateID, i.AuthorID, i.Title, i.ISBN, a.FirstName, a.LastName
                    from BookTemplates i
                    join Author a on i.AuthorID = a.AuthorID");

                Templates.DataSource = dt.Rows;
                Templates.DataBind();
            }
        }
    }
}