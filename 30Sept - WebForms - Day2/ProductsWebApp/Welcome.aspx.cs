using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_BAL;

namespace ProductsWebApp
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GETTING COOKIES FROM BROWSER which was sent in signup page
            HttpCookie cookie = Request.Cookies.Get("Custdata");
            Customer c = new Customer();
            c.Firstname = cookie["fname"];
            c.Lastname = cookie["lname"];
          
            lblwelcome.Text = "Welcome " + c.Firstname + ' ' + c.Lastname;
        }

       
    }
}