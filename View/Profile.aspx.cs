using Project1._0.Controller;
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
    public partial class Profile : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    MsUser u = (MsUser)Session["user"];
                    int id = u.UserID;
                    updateInformation(id);
                }
            }
            
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            if (!UserController.validateUsername(username))
            {
                lblErrorUsername.Text = "Lenght harus 5<X<15";
                return; 
            }
            string email = tbEmail.Text.Trim();
            if (!UserController.validateEmail(email))
            {
                lblErrorEmail.Text = "Harus .com";
                return; 
            }
            bool male = rbMale.Checked;
            bool female = rbFemale.Checked;
            if (!UserController.validateGender(male, female))
            {
                lblErrorGender.Text = "pilih dong";
                return;
            }
            string sex;
            if (rbMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            
            MsUser us = (MsUser)Session["user"];
            int id = us.UserID;


            DateTime dob = DateTime.Parse(tbDOB.Text);

            if(UserController.updateUserInformation(id, tbUsername.Text, tbEmail.Text, sex, dob))
            {
                lblUpdateStatus.Text = "TRUE";
            }

            updateInformation(id);



        }

        private void updateInformation(int id)
        {
            MsUser updated = UserController.getUserbyID(id);
            tbUsername.Text = updated.UserName;
            tbEmail.Text = updated.UserEmail;
            if (updated.UserGender == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            tbDOB.Text = updated.UserDOB.ToString("MM dd yyyy");
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = tbOldPassword.Text;
            string newPassword = tbNewPassword.Text;
            if (UserController.isEmpty(oldPassword))
            {
                lblErrorOldPassword.Text = "cant empty";
                return;
            }
            if (UserController.isEmpty(newPassword))
            {
                lblErrorNewPassword.Text = "cant empty";
                return;
            }
            
            MsUser us = (MsUser)Session["user"];
            int id = us.UserID;
           
            bool validateOldPassword = UserController.validateOldPassword(id, tbOldPassword.Text);
            if(!validateOldPassword)
            {
                lblErrorOldPassword.Text = "password salah";
                return;
            }
            else
            {
                string password = tbNewPassword.Text.Trim();
                if (!UserController.validatePassword(password))
                {
                    lblErrorNewPassword.Text = "only alphanumeric";
                    return; 
                }
                else
                {
                    if(UserController.updatePassword(id, tbNewPassword.Text))
                    {
                        lblUpdatePassword.Text = "TRUE";
                    }
                }
            }

        }



    }
}