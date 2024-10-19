using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMCS_MVC_App.Models;

namespace CMCS_MVC_Tests.Model_Tests
{
    [TestFixture]
    public class ClaimTests
    {
        //Code Attribution for some of the below:
        //Author: fb-shaik
        //Website: GitHub
        //Link: https://github.com/fb-shaik/PROG6212-Group1-2024/blob/main/EmployeeLeaveManagement_G1_Unit%20Testing.zip
        //Date accessed: 17 October 2024

        [Test]
        public void Claim_SetStatus_ReturnsCorrectStatus()
        {
            //Arrange - Sets up the initial state required for the test
            var claim = new Claim();

            //Act - Performs the action / behaviour that you are testing
            claim.Status = "Pending";

            //Assert - Verifies that the outcome of the action matches the expected result
            Assert.That(claim.Status, Is.EqualTo("Pending"));
        }

        [Test]
        public void Claim_SetHoursWorked_ReturnsCorrectHoursWorked()
        {
            //Arrange - Sets up the initial state required for the test
            var claim = new Claim();

            //Act - Perfoems the action / behaviour that you are testing
            claim.HoursWorked = 98;

            //Assert - Verifies that the outcome of the action matches the expected result
            Assert.That(claim.HoursWorked, Is.EqualTo(98));
        }

        [Test]
        public void Claim_SetAdditionalNote_ReturnsCorrectAdditionalNote()
        {
            //Arrange - Sets up the initial state required for the test
            var claim = new Claim();

            //Act - Perfoems the action / behaviour that you are testing
            claim.AdditionalNote = "I want my money. I am broke.";

            //Assert - Verifies that the outcome of the action matches the expected result
            Assert.That(claim.AdditionalNote, Is.EqualTo("I want my money. I am broke."));
        }

        [Test]
        public void Claim_SetClaimId_ReturnsCorrectClaimId()
        {
            //Arrange - Sets up the initial state required for the test
            var claim = new Claim();

            //Act - Perfoems the action / behaviour that you are testing
            claim.ClaimId = 15;

            //Assert - Verifies that the outcome of the action matches the expected result
            Assert.That(claim.ClaimId, Is.EqualTo(15));
        }

    }
}
