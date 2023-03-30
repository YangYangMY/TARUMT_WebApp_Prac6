using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac6
{
    public partial class Figure1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitorNum.Text = (int)(Application["CurrentUsers"]).ToString();  
            lblTime.Text = DateTime.Now.ToString();


        }

        protected void ButtonApply_Click(object sender, EventArgs e)
        {
            if(DDLCSS.SelectedIndex == 0)
            {
                Session["SelectedCss"] = "Standard.css";
            }
            else if(DDLCSS.SelectedIndex == 1)
            {
               Session["SelectedCss"] = "Special.css";
            }
            
        }

        protected void CheckPreference_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPreference.Checked)
            {
                HttpCookie myCookie = new HttpCookie("SavedTheme", DDLCSS.SelectedValue);
                Response.Cookies.Add(myCookie);
                myCookie.Expires = DateTime.Now.AddDays(30);
            }
            else
            {
               Response.Cookies["SavedTheme"].Expires = DateTime.Now.AddDays(-30);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Figure2.aspx?redirect=" +
                Server.UrlEncode(Request.QueryString["SavedTheme"]));
        }
    }
}