using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPortal.Tests
{
    public class AccountControllerTests
    {
        public void InloggningsTest()
        {
              
            string UserName = "admin";
            string Password = "admin";
            string excpected = "Inloggning lyckades";

            string act = Login(UserName, Password);
        }
    }
}
