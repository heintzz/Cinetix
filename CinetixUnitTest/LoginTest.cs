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

        [TestMethod]
        public void LoginAuthTest()
        {
            string email = "mhasnanr@gmail.com";
            string password = "bismillahbisa";

            Login loginClass = new Login();
            bool isExist = loginClass.IsUserExist(email, password);

            bool expected = true;

            Assert.AreEqual(expected, isExist, "Pengguna tidak terdaftar.");
        }
    }
}
