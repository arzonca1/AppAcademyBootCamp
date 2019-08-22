using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Widget_Library.Data;


namespace Widget_Library.Controls
{
    public partial class QuoteOfTheDay : System.Web.UI.UserControl
    {
        public bool randomize { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (randomize) Quote.Text = QuotesData.GetRandomQuote();
                else Quote.Text = QuotesData.GetQuoteOfTheDay();
            }
        }
    }
}