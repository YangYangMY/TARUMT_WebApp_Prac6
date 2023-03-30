using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac6
{
    public partial class Figure2 : System.Web.UI.Page
    {
        int _num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["SavedTheme"] != null)
            {
                Session["SelectedCss"] = Request.Cookies["SavedTheme"].Value +".css";
                string a =(String) Session["SelectedCss"];
            }
            else
            {
                Session["SelectedCss"] = "Standard.css";
            }

            this._num = (int)(Application["CurrentUsers"]);
            lblVisitorNum.Text = _num.ToString();
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}