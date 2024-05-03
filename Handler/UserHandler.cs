using Project1._0.Model;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Handler
{
    public class UserHandler
    {
        public static MsUser login(string username, string password)
        {
            if (UserRepository.login(username, password) != null)
            {
                return UserRepository.login(username, password);
            }
            else
            {
                return null;
            }
        }

        public static MsUser register(string username, string email, string gender, string password, DateTime DOB)
        {
            return UserRepository.addCustomer(username, email, gender, password, DOB);
        }

        public static List<MsUser> getAllUsers()
        {
            return UserRepository.getAllUsers();
        }

        public static bool updateUserInformation(int id, string username, string email, string gender, DateTime dob)
        {
            if(UserRepository.getUserbyID(id) != null)
            {
                UserRepository.updateUserInformation(id, username, email, gender, dob);
                return true;
            }
            return false;
        }

        public static MsUser getUserbyID(int id)
        {
            return UserRepository.getUserbyID(id);
        }

        public static string getPassword(int id)
        {
            return UserRepository.getPassword(id);
        }

        public static bool updatePassword(int id, string newPassword)
        {
            return UserRepository.updatePassword(id, newPassword);
        }
    }
}