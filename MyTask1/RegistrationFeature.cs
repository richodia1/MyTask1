using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestDataRepository;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MyTask1
{
    [Binding]
    public class RegistrationFeature
    {
        RegisterRepo _repo = new RegisterRepo();

        [Given(@"that a user want to register successfully with valid '(.*)':email and '(.*)':password")]
        public void GivenThatAUserWantToRegisterSuccessfullyWithValidEmailAndPassword(string email, string password)
        {
            // Act
            var actualResult = _repo.SuccessfulRegistration(email, password);

            // Assert
            Assert.AreEqual(200, _repo.getRegisterationStatusCode(email, password));
            Assert.IsNotNull(actualResult);
        }



        [Then(@"I should get a successful registration response with token")]
        public void ThenIShouldGetASuccessfulRegistrationResponseWithTokenUsingEmailAndPassword(string email, string password)
        {
            var actualResult = _repo.SuccessfulRegistration(email, password);
            Assert.AreEqual(200, _repo.getRegisterationStatusCode(email, password));
        }

        [Given(@"that a user Register with an incomplete input parameter with email: '(.*)' and  '(.*)':")]
        public void GivenThatAUserRegisterWithAnIncompleteInputParameterWithEmailAndInvalidPassword(string email, string password)
        {
            Assert.AreEqual(400, _repo.getRegisterationStatusCode(email, password));
            var actualResult = _repo.UnsuccessfulRegistration(email, password);
            Assert.IsNotNull(actualResult);
        }

        [Then(@"my response code for incomplete input registration should be (.*) badrequest and error response")]
        public void ThenMyResponseCodeForIncompleteInputRegistrationShouldBeBadrequestAndErrorResponse(string email, string password)
        {
            Assert.AreEqual(400, _repo.getRegisterationStatusCode(email, password));

        }

    }
}
