using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MyTask1
{
    class UsersListFeatures
    {
        [Given(@"that a user exist on the system with a return status code of (.*)")]
        public void GivenThatAUserExistOnTheSystemWithAReturnStatusCodeOf(int p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I trigger Http Get request")]
        public void WhenITriggerHttpGetRequest()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should get all the list of users")]
        public void ThenIShouldGetAllTheListOfUsers()
        {
           // ScenarioContext.Current.Pending();
        }

    }
}
