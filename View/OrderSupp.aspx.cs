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
    public partial class OrderSupp : System.Web.UI.Page
    {
        SupplementRepository suppRepo = new SupplementRepository();
        CartRepository cartRepo = new CartRepository();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            
            MsUser u = (MsUser)Session["user"];
            int id = u.UserID;
            
            if (!IsPostBack)
            {
                gvSupplements.DataSource = suppRepo.getAllSupplements();
                gvSupplements.DataBind();
                gvCart.DataSource = cartRepo.getAllUserCart(id);
                gvCart.DataBind();

            }
            
        }

        protected void gvSupplement_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            MsUser u = (MsUser)Session["user"];
            int id = u.UserID;
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvSupplements.Rows[rowIndex];

                // Get the controls in the GridView row
                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                int quantity = Convert.ToInt32(txtQuantity.Text);

                // Extracting other values
                int supplementID = Convert.ToInt32(row.Cells[0].Text); // Assuming SupplementID is in the first cell
                DateTime expiryDate = Convert.ToDateTime(row.Cells[2].Text); // Assuming SupplementExpiryDate is in the third cell
                int price = Convert.ToInt32(row.Cells[3].Text); // Assuming SupplementPrice is in the fourth cell
                int supplementTypeID = Convert.ToInt32(row.Cells[4].Text);
                string suppName = row.Cells[1].Text;
                // Now you can use these values for processing the order
                //ProcessOrder(supplementID, quantity, expiryDate, price);
                cartRepo.addtoCart(id, supplementID, quantity);
                gvCart.DataSource = cartRepo.getAllUserCart(id);
                gvCart.DataBind();
                // Refresh the cart GridView


            }
        }

        protected void gvSupplement_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gvSupplement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            MsUser u = (MsUser)Session["user"];
            int id = u.UserID;
            CartRepository.deleteAllUserCart(id);
            gvCart.DataSource = cartRepo.getAllUserCart(id);
            gvCart.DataBind();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            MsUser u = (MsUser)Session["user"];
            int id = u.UserID;
            List<MsCart> userCarts = cartRepo.getAllUserCart(id);
            DateTime today = DateTime.Now;

            if (userCarts != null && userCarts.Count >0)
            {
                foreach(var cartItem in userCarts)
                {
                    TransactionRepository.addTransaction(id, today, cartItem.SupplementID, cartItem.Quantity);
                }
                CartRepository.deleteAllUserCart(id);
                gvCart.DataSource = cartRepo.getAllUserCart(id);
                gvCart.DataBind();
            }
        }
    }
}