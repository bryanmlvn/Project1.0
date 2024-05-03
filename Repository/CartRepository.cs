using Project1._0.Factory;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Repository
{
    public class CartRepository
    {
        static Database1Entities db = new Database1Entities();
        CartFactory cf = new CartFactory();
        public List<MsCart> getAllUserCart(int id)
        {
            List<MsCart> all = (from p in db.MsCarts where p.UserID == id select p).ToList();
            return all;
        }

        public MsCart addtoCart(int userID, int SupplementID, int Quantity)
        {
            MsCart c = cf.createCart(userID, SupplementID, Quantity);
            db.MsCarts.Add(c);
            db.SaveChanges();
            return c;
        }
        public static void deleteAllUserCart(int userId)
        {
            var userCarts = db.MsCarts.Where(c => c.UserID == userId);
            db.MsCarts.RemoveRange(userCarts);
            db.SaveChanges();
        }

    }
}