using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestDataRepository;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MyTask1
{
    [Binding]
    class UsersListFeatures
    {
        UsersRepo _repo = new UsersRepo();
        public int statusCode;
        [Given(@"that a user exist on the system with a return status code of (.*)")]
        public void GivenThatAUserExistOnTheSystemWithAReturnStatusCodeOf(int myStatusCode)
        {
            // Act
            statusCode = _repo.getUsersStatusCode();

            // Assert
            Assert.AreEqual(myStatusCode, statusCode);
        }

        [When(@"I trigger Http Get request")]
        public void WhenITriggerHttpGetRequest()
        {
            var actualResult = _repo.GetUsersList();

        }

        [Then(@"I should get all the list of users")]
        public void ThenIShouldGetAllTheListOfUsers()
        {
            var actualResult = _repo.GetUsersList();
            Assert.IsNotNull(actualResult);

        }

    }
}


