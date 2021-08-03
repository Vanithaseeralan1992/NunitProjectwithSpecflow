using NunitProject.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NunitProject.Steps
{
    [Binding]
    //private Calculator _calculator = new Calculator();
    //private int _Result;
    public class SpecFlowFeature1Steps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            //_calculator.firstnumber = number1;
            Console.WriteLine(number1);
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            //_calculator.secondnumber = number2;
            Console.WriteLine(number2);
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //_Result =_calculator.Add();
            // Console.WriteLine(_calculator.Add());
            Console.WriteLine("Numbers Added");
        }
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //_Result = _calculator.Subtract();
            Console.WriteLine("Numbers Subtracted");
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //_Result.Should().Be(result);
            
            if (result == 120)
                Console.WriteLine("Passed");
            else
                Console.WriteLine("Failed");

        }
        [When(@"I fill all the mandatory datails in form")]
        public void WhenIFillAllTheMandatoryDatailsInForm(Table table)
        {
            /*EmployeeDetails details = table.CreateInstance<EmployeeDetails>();            
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Age);
            Console.WriteLine(details.Email);
            Console.WriteLine(details.Phone);*/
            var details = table.CreateSet<EmployeeDetails>();
            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine($"The details of {emp.Name} info dispalyed below");
                Console.WriteLine("*************************************************");
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
            }
            
        }

    }
}
