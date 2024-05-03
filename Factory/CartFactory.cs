using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Factory
{
    public class CartFactory
    {
        
        public MsCart createCart(int userID, int suppID, int quantity)
        {
            MsCart c = new MsCart();
            c.UserID = userID;
            c.SupplementID = suppID;
            c.Quantity = quantity;
            
            return c;
        }
    }
}