using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MyTask1
{
    class RegistrationFeature
    {
        [Given(@"that a user want to register successfully with valid '(.*)':email and '(.*)':password")]
        public void GivenThatAUserWantToRegisterSuccessfullyWithValidEmailAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I trigger Post request registration")]
        public void WhenITriggerPostRequestRegistration()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should get a successful registration response with token using '(.*)':email and '(.*)':password")]
        public void ThenIShouldGetASuccessfulRegistrationResponseWithTokenUsingEmailAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"that a user Register with an incomplete input parameter with email: '(.*)' and invalid password: '(.*)':")]
        public void GivenThatAUserRegisterWithAnIncompleteInputParameterWithEmailAndInvalidPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"my response code for incomplete input registration should be (.*) badrequest and error response")]
        public void ThenMyResponseCodeForIncompleteInputRegistrationShouldBeBadrequestAndErrorResponse(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
