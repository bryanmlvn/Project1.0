using Project1._0.Controller;
using Project1._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1._0.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
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
            string password = tbPassword.Text.Trim();
            if (!UserController.validatePassword(password))
            {
                lblErrorPassword.Text = "only alphanumeric";
                return; // Exit the event handler
            }
            string sex = "";
            if (male)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            DateTime dob = DateTime.Parse(tbDOB.Text);
            UserController.register(username, email, sex, password, dob);
            Response.Redirect("Login.aspx");


        }
        
    }
}