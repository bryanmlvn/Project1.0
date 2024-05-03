using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Repository
{
    public class SupplementRepository
    {
        static Database1Entities db = new Database1Entities();
        public List<MsSupplement> getAllSupplements()
        {
            List<MsSupplement> supps = (from p in db.MsSupplements select p).ToList();
            return supps;
        }
        public static string getSupplementName(int suppID)
        {
            return (from p in db.MsSupplements where p.SupplementID == suppID select p.SupplementName).FirstOrDefault();
        }
    }
}