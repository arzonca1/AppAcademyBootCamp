using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Widget_Library.Controls
{
    public partial class RenderTime : System.Web.UI.UserControl
    {
        private string _label;
        public string Label
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_label))
                {
                    return _label;
                }
                else
                {
                    return "Page rendered at: ";
                }
            }
            set { _label = value; }
        }

        private string _format;
        public string Format
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_format))
                {
                    return _format;
                }
                else
                {
                    return "M/d/yyyy h:mm tt";
                }
            }
            set { _format = value; }
        }
    }
}