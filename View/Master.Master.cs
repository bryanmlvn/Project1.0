using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateNavbar();
            }


        }

        private void UpdateNavbar()
        {
            if(Session["user"] != null)
            {
                MsUser currUser = (MsUser)Session["user"];
                if (currUser.UserRole == "admin")
                {
                    btnOrderSupp.Visible = false;
                    btnHistory.Visible = false;
                }
                else if (currUser.UserRole == "customer")
                {
                    btnHome.Visible = false;
                    btnManageSupp.Visible = false;
                    btnOrderQueue.Visible = false;
                    btnTransactionReport.Visible = false;
                }
            }
            else
            {

            }
        }
            
          
        protected void btnHome_Click(object sender, EventArgs e)
        {

        }

        protected void btnManageSupp_Click(object sender, EventArgs e)
        {

        }

        protected void btnOrderSupp_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderSupp.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
           
            Response.Redirect("Login.aspx");

        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {

        }

        protected void btnTransactionReport_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}