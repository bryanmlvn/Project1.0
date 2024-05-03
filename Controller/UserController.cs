using Project1._0.Handler;
using Project1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1._0.Controller
{
    public class UserController
    {
        public static MsUser login(string username, string password)
        {
            return UserHandler.login(username, password);
        }
        public static bool validateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 5 || username.Length > 15 || !IsAlphabetWithSpace(username))
            {

                return false; // Exit the event handler
            }
            return true;
        }
        public static bool validateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            {
                return false; // Exit the event handler
            }
            return true;
        }
        public static bool validateGender(bool male, bool female)
        {
            if (!male && !female)
            {
                return false;
            }
            return true;
        }
        public static bool validatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || !IsAlphaNumeric(password))
            {
                return false; // Exit the event handler
            }
            return true;
        }

        public static bool isEmpty(string s)
        {
            if(s == "" || s == null)
            {
                return true;
            }
            return false;
        }
        public static bool register(string username, string email, string sex, string password, DateTime dob)
        {
            
            if(UserHandler.register(username, email, sex, password, dob) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<MsUser> getAllUsers()
        {
            return UserHandler.getAllUsers();
        }

        public static bool updateUserInformation(int id, string username, string email, string gender, DateTime dob)
        {
            return UserHandler.updateUserInformation(id, username, email, gender, dob);
        }

        public static MsUser  getUserbyID(int id)
        {
            return UserHandler.getUserbyID(id);
        }


        public static bool validateOldPassword(int id, string oldPassword)
        {
            string pw = UserHandler.getPassword(id);
            if(oldPassword != pw)
            {
                return false;
            }
            return true;


        }

        public static bool updatePassword(int id, string newPassword)
        {
            return UserHandler.updatePassword(id, newPassword);
        }



        private static bool IsAlphabetWithSpace(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;

        }
        private static bool IsAlphaNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}