using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader createTransactionHeader(int userID, DateTime date)
        {
            TransactionHeader th = new TransactionHeader();
            
            th.UserID = userID;
            th.TransactionDate = date;
            th.Status = "unhandled";
            return th;
        }
        public static TransactionDetail createTransactionDetail(int supplementID, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            
            td.SupplementID = supplementID;
            td.Quantity = quantity;
            return td;
        }
    }
}