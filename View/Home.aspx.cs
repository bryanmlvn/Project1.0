using Project1._0.Controller;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateRole();
                
            }
        }
        private void UpdateRole()
        {
            if (Session["user"] != null)
            {
                MsUser currUser = (MsUser)Session["user"];
                if (currUser.UserRole == "admin")
                {
                    lblRole.Text = "ROLE: Admin";
                    gvUser.DataSource = UserController.getAllUsers();
                    gvUser.DataBind();
                }
                else if (currUser.UserRole == "customer")
                {
                    lblRole.Text = "ROLE: Customer";
                }
            }
            else
            {
                lblRole.Text = "Guest";
            }
        }

    }
}