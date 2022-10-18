using NUnit.Framework;
using SpecFlowBasic;
namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        CalculatorApp app = new CalculatorApp();
        int a, b;
        double d;
        double dans;
        int ans;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            a = number;
            Console.WriteLine($"Number 1 : {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            b = number;
            Console.WriteLine($"Number 2 : {number}");

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {

            Console.WriteLine("Addition"); ;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
           // ans= a + b;
            ans = app.Add(a, b);

            Console.WriteLine($"Added value: {ans}");
            Assert.AreEqual(ans, result);

        }

        //-Subtraction

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Console.WriteLine("Subtraction");
        }

        [Then(@"the subtracted result be (.*)")]
        public void ThenTheSubtractedResultBe(int p0)
        {
            // ans = a-b;
            ans = app.Subtract(a, b);

            Console.WriteLine($"Subtracted value : {ans}");
            Assert.AreEqual(ans, p0);
        }
        //Multiplication

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Console.WriteLine("Multiplication");
        }

        [Then(@"the multiplication result be (.*)")]
        public void ThenTheMultiplicationResultBe(int p0)
        {
            // ans = a * b; 
            ans = app.Multiply(a, b);
            Console.WriteLine($"Multiplication value : {ans}");
            Assert.AreEqual(ans, p0);

        }
        //Division

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Console.WriteLine("Division");
        }

        [Then(@"the division result be (.*)")]
        public void ThenTheDivisionResultBe(int p0)
        {
            //ans = b!=0 ? a / b : 0;
            ans = app.Divide(a, b);
            Console.WriteLine($"Division value : {ans}");
            Assert.AreEqual(ans, p0);
        }

        //Squareroot

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Decimal p0)
        {
            d = (double)p0;
        }

        [When(@"the number is taken squareroot")]
        public void WhenTheNumberIsTakenSquareroot()
        {
            Console.WriteLine("taking squareroot..");
        }

        [Then(@"the sqr root result be (.*)")]
        public void ThenTheSqrRootResultBe(Decimal p0)
        {
            dans = app.Sqrroot(d);
            Console.WriteLine($"Sqr root value of {d}: {dans}");
            Assert.AreEqual(dans, p0);

        }




    }
}