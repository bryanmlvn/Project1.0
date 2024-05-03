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
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser u = (MsUser)Session["user"];
            int id = u.UserID;
            string role = UserRepository.getRole(id);
            if (!IsPostBack)
            {
                if(role == "customer")
                {
                    gvHistory.DataSource = TransactionRepository.getAllUserTransactionsByID(id);
                    gvHistory.DataBind();
                }
                if(role == "admin")
                {
                    gvHistory.DataSource = TransactionRepository.getAllTransactions();
                    gvHistory.DataBind();
                }
                if(role =="guest")
                {
                    Response.Redirect("Login.aspx");
                }

                
            }
        }

        protected void gvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvHistory.Rows[gvHistory.SelectedIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            Response.Redirect("TransactionDetails.aspx?Id=" + id);
        }
    }
}