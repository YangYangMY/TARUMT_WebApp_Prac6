using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac6
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx?fname=" + TextBoxName.Text + "&fprogram=" + RadioButtonList1.SelectedValue + "&flanguage=" + DropDownList1.SelectedIndex);
        }
    }
}