using Cinetix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinetixUnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void FormValidationTest()
        {            
            string email = "dasd";
            string password = "kobisa";            

            Login loginClass = new Login();
            bool isEmpty = loginClass.IsFormFilled(email, password);

            bool expected = false;

            Assert.AreEqual(expected, isEmpty, "Form belum selesai diisi.");
        }
    }
}
