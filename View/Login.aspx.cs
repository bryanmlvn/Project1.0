using Project1._0.Controller;
using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["username"];
                tbUsername.Text = cookie != null ? cookie.Value : "";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            MsUser u = UserController.login(tbUsername.Text, tbPassword.Text);

            if( u != null)
            {
                Session["user"] = u;
                if (cbRemember.Checked == true)
                {
                    HttpCookie cookie = new HttpCookie("username");
                    cookie.Value = tbUsername.Text;
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblIncorrect.Text = "Wrong combination of email and password";
            }


        }
    }
}