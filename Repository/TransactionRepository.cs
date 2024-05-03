using Project1._0.Factory;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Repository
{
    public class TransactionRepository
    {
        static Database1Entities db = new Database1Entities();
        public static void addTransaction(int userID, DateTime date, int supplementID, int quantity)
        {
            TransactionHeader th = TransactionFactory.createTransactionHeader(userID, date);
            TransactionDetail td = TransactionFactory.createTransactionDetail( supplementID, quantity);
            db.TransactionHeaders.Add(th);
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }

        public static List<TransactionHeader> getAllUserTransactionsByID(int id)
        {
            List<TransactionHeader> all = (from p in db.TransactionHeaders where p.UserID == id select p).ToList();
            return all;
        }
        public static List<TransactionHeader> getAllTransactions()
        {
            List<TransactionHeader> all = (from p in db.TransactionHeaders select p).ToList();
            return all;
        }

        public static TransactionDetail getTransactionDetailByID(int id)
        {
            return (from p in db.TransactionDetails where p.TransactionID == id select p).FirstOrDefault();
        }
    }
}