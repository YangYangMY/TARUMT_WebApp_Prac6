using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac6
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["SavedValue"] != null)
            {
                lblCookies.Text = "Cookie Found! The Value of the Cookie is " + Request.Cookies["SavedValue"].Value;
            }
            else
            {
                
                lblCookies.Text = "Cookie Not Found! Now you can set Cookies with value By using set Cookie Button!";
            }

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("SavedValue", TextBoxCookie.Text);
            Response.Cookies.Add(myCookie);
            myCookie.Expires = DateTime.Now.AddDays(1);
            lblCookies.Text = "Cookie Found! The Value of the Cookie is " + Request.Cookies["SavedValue"].Value;
        }
    }
}