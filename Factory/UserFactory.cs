using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Factory
{
    public class UserFactory
    {
        public MsUser createCustomer(string username, string email, string gender, string password, DateTime DOB)
        {
            MsUser u = new MsUser();
            u.UserName = username;
            u.UserEmail = email;
            u.UserGender = gender;
            u.UserPassword = password;
            u.UserDOB = DOB;
            u.UserRole = "customer";

            return u;
        }
    }
}