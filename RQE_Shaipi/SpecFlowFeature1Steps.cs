using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Shaipi
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, number2, sum;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(double p0)
        {
            number = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(double p0)
        {
            number2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = number + number2;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            sum = number - number2;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            sum = number * number2;
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            sum = number / number2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.Equal(expected: p0, actual: sum);
        }
    }
}
