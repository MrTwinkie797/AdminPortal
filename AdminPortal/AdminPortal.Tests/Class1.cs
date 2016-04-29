using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

using AdminPortal.Tests;
using AdminPortal.Controllers;

namespace AdminPortal.Tests
{
    public class AccountControllerTests
    {
        public void InloggningsTest()
        {
            AccountController ac = new AccountController();
            string UserName = "admin";
            string Password = "admin";
            string excpected = "Inloggning lyckades";

            string act = ac.Login(UserName, Password);

            Assert.Equal(excpected, result);
        }
    }
}
