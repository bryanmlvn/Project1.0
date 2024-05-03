using Project1._0.Factory;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Repository
{
    public class UserRepository
    {
        static Database1Entities db = new Database1Entities();
        public static MsUser login(string username, string password)
        {
            MsUser u = (from us in db.MsUsers where us.UserName.Equals(username) && us.UserPassword.Equals(password) select us).FirstOrDefault();
            return u;
        }
        public static MsUser addCustomer(string username, string email, string gender, string password, DateTime DOB)
        {
            UserFactory uf = new UserFactory();
            MsUser us = uf.createCustomer(username, email, gender, password, DOB);

            db.MsUsers.Add(us);
            db.SaveChanges();
            return us;
        }

        public static List<MsUser> getAllUsers()
        {
            return db.MsUsers.ToList();
        }
        public static MsUser getUserbyID(int id)
        {
            MsUser user = (from u in db.MsUsers where u.UserID.Equals(id) select u).FirstOrDefault();
            return user;
        }
        public static string getRole(int id)
        {
            return (from u in db.MsUsers where u.UserID.Equals(id) select u.UserRole).FirstOrDefault();
        }

        public static void updateUserInformation(int id, string username, string email, string gender, DateTime dob)
        {
            MsUser user = db.MsUsers.Find(id);
           
            user.UserName = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = dob;
            db.SaveChanges();
                
            
            
            
        }

        public static string getPassword(int id)
        {
            MsUser user = getUserbyID(id);
            return user.UserPassword;
        }

        public static bool updatePassword(int id, string newPassword)
        {
            MsUser user = db.MsUsers.Find(id);
            if (user != null)
            {
                user.UserPassword = newPassword;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        
    }
}