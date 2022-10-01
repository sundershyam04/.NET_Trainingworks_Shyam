using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductsWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
                Response.Write("Welcome to Login Page");
                
            }
            else  if(txtusername.Text=="sunder" && txtpassword.Text=="sunder@123")
            {
                Response.Write("Logged in successfully");
                lblloginstatus.Text = "Login successfull";
                Response.Redirect(@"~\SignUp.aspx");

            }
            else
            {
                Response.Write("Incorrect credentials");
                lblloginstatus.Text = "Incorrect credentials ..Try Again";

            }

            }
        }
    }