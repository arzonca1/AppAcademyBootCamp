using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Widget_Library.Data;

namespace Widget_Library.Controls
{
    public partial class WeatherControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WeatherInformation.Visible = false;
                Error.Visible = false;
            }
        }
        protected void GetWeather_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string zip = Zip.Text;

                Dictionary<string, string> data = WeatherData.CallApi(zip);

                if (data != null)
                {
                    WeatherInformation.Visible = true;
                    Error.Visible = false;

                    WeatherInformation.DataSource = data;
                    WeatherInformation.DataBind();
                }
                else
                {
                    WeatherInformation.Visible = false;
                    Error.Visible = true;
                }
            }
        }


    }
}