using Customer_BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductsWebApp
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void caldob_SelectionChanged(object sender, EventArgs e)
        {
            lbldobfinal.Text= caldob.SelectedDate.Date.ToString();
        }

        protected void btnsigup_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Custdata");

            cookie.Expires = DateTime.Now.AddMinutes(15);

            Customer cust = new Customer();

            cust.Firstname = txtfirstname.Text;

            cust.Lastname = txtlastname.Text;

            cust.DateofBirth = caldob.SelectedDate.Date;

            cust.State = txtstate.Text;

            cust.City = txtcity.Text;

            //Summary:
            //           Cookie stores a name valued collection of all strings

            cookie.Values.Add("fname",cust.Firstname);
            cookie.Values.Add("lname",cust.Lastname);
            cookie.Values.Add("dob", cust.DateofBirth.ToString());
            cookie.Values.Add("state", cust.State);
            cookie.Values.Add("city", cust.City);

            // Adding cookie to browser 

            Response.Cookies.Add(cookie);

            Response.Redirect(@"~\Welcome.aspx");


            
        }
    }
}