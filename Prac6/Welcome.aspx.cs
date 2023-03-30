using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac6
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["flanguage"] == "0")
            {
                lblName.Text = "Hello, " + Request.QueryString["fname"];
                lblProgramme.Text = " from " + Request.QueryString["fprogram"];
                lblWelcome.Text = "Welcome to BAIT2113 Web Application Development Website";
                lblCache.Text = "This page is cached on " + DateTime.Now.ToString();
            }
            else
            {
                lblName.Text = "こんにちは、" + Request.QueryString["fname"];
                lblProgramme.Text = " から " + Request.QueryString["fprogram"];
                lblWelcome.Text = "BAIT2113 Web アプリケーション開発 Web サイトへようこそ";
                lblCache.Text = "このページは にキャッシュされています " + DateTime.Now.ToString();
            }

        }
    }
}