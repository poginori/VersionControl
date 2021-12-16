using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;

namespace UnitTestExample.Test
{

    class AccountControllerTestFixture
    {
        [Test,
           TestCase("abcd1234", false),
           TestCase("irf@uni-corvinus", false),
           TestCase("irf.uni-corvinus.hu", false),
           TestCase("irf@uni-corvinus.hu", true)
            ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var AccountController = new AccountController();

            //Act
            var ActualResult = AccountController.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expectedResult, ActualResult);

        }
        [Test,
            TestCase("Abc1", false),
            TestCase("abcdabcd", false),
            TestCase("abcdABCD",false),
            TestCase("ABCDABCD", false),
            TestCase("Abc1", false),
            TestCase("Abc1Abc1",true)
            ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var AccountController = new AccountController();
            //Act
            var ActualResult = AccountController.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expectedResult, ActualResult);
        }
        [Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
            ]
        public void TestRegisterHappyPath(string email, string password)
        {
            //Arrange
            var AccountController = new AccountController();

            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;
            //Act
            var actualresult = AccountController.Register(email, password);
            var actualResult = accountController.Register(email, password);


            //Assert
            Assert.AreEqual(email, actualresult.Email);
            Assert.AreEqual(password, actualresult.Password);
            Assert.AreNotEqual(Guid.Empty, actualresult.ID);

            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);
        }
        [
    Test,
    TestCase("irf@uni-corvinus.hu", "Abcd1234")
]
        public void TestRegisterApplicationException(string newEmail, string newPassword)
        {
            // Arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Throws<ApplicationException>();
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            // Act
            try
            {
                var actualResult = accountController.Register(newEmail, newPassword);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ApplicationException>(ex);
            }

            // Assert
        }

        [Test,
           TestCase("irf@uni-corvinus", "Abcd1234"),
           TestCase("irf.uni-corvinus.hu", "Abcd1234"),
           TestCase("irf@uni-corvinus.hu", "abcd1234"),
           TestCase("irf@uni-corvinus.hu", "ABCD1234"),
           TestCase("irf@uni-corvinus.hu", "abcdABCD"),
           TestCase("irf@uni-corvinus.hu", "Ab1234"),
            ]
        public void TestRegisterValidateException(string email, string password)
        {
            //Arrange
            var AccountController = new AccountController();
            //Act
            try
            {
                var ActualResult = AccountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);

            }

            //Assert
        }
    }
}
