using LoginTestSpecFlow.Features;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace LoginTestSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
       
        string username = "testuser2";
        string password = "Test2@123";
        bool status;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            Console.WriteLine("Homepage");
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            Console.WriteLine("Loginpage");
        }

        [When(@"User enter ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEnterAnd(string uname, string p1)
        {
            Assert.AreEqual(username, uname,"username not correct");
            Assert.AreEqual(password, p1,"password not correct");
            status = true;
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
           
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            if(status == true)
            {
                Console.WriteLine("Successfully Login");
            }
          
        }

        //----------------------LOGOUT---------------


        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            Console.WriteLine("logging out........");
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine("LOGGED OUT SUCCESSFULLY");
        }

        //-------------------PRODUCTSCART-------------
        bool valid=false;
        List<string> Products = new List<string> { "Dell inspiron 3502", "ASus Zenphone", "iPhone", "GalaxyPhone" };
        List<string> Cart = new List<string>();


        [Given(@"list of products available")]
        public void GivenListOfProductsAvailable()
        {
            Console.WriteLine("Products");
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }

        [Given(@"productscart empty initially")]
        public void GivenProductscartEmptyInitially()
        {
            Console.WriteLine("Cart empty initially");
        }

        [When(@"products added to cart validate cart")]
        public void WhenProductsAddedToCartValidateCart()
        {

            //Adding products to cart

            Cart.Add(Products[0]);
            Cart.Add(Products[2]);

            //validating cart

            if (Cart.Count!=0)
            {
                valid = true;
            }

            
        }

        [Then(@"if valid display ""([^""]*)"" message")]
        public void ThenIfValidDisplayMessage(string p0)
        {
            Assert.AreEqual(valid, true, "Invalid card : Empty cart ");
            Console.WriteLine(p0);
        }


    }
}
