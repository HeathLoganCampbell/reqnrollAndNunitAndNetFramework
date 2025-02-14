using NUnit.Framework;
using Reqnroll;

namespace ReqnrollXNunit.Tests
{
    [Binding]
    public class CarStepDefinitions
    {
        [Given(@"the car has sufficient fuel")]
        public void GivenTheCarHasSufficientFuel()
        {
        }

        [When(@"I turn the ignition key")]
        public void WhenITurnTheIgnitionKey()
        {
        }

        [Then(@"the engine should start")]
        public void ThenTheEngineShouldStart()
        {
            Assert.Pass();
        }

        [Given(@"the car has insufficient fuel")]
        public void GivenTheCarHasInsufficientFuel()
        {
        }
    }
}