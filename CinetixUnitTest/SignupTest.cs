using Cinetix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinetixUnitTest
{
    [TestClass]
    public class SignupTest
    {        
        // Signup
        [TestMethod]
        public void UniqueEmailTest()
        {
            string email = "mhasnanr2@gmail.com";

            Signup signupClass = new Signup();
            bool isNotAvailable = signupClass.IsEmailInUse(email);
            bool expected = false;

            Assert.AreEqual(expected, isNotAvailable, "Email sudah digunakan.");
        }       

        [TestMethod]
        public void PasswordMatchingTest()
        {
            string password1 = "password123";
            string password2 = "password123";

            Signup signupClass = new Signup();
            bool isMatch = signupClass.PasswordIsMatch(password1, password2);

            bool expected = true;

            Assert.AreEqual(expected, isMatch);
        }

        [TestMethod]
        public void EmailValidationTest()
        {
            string email = "jdsakjksad";

            Signup signupClass = new Signup();
            bool isValid = signupClass.IsValidEmail(email);

            bool expected = false;

            Assert.AreEqual(expected, isValid, "Email tidak valid.");
        }

        [TestMethod]
        public void PasswordLengthTest()
        {            
            string password = "abc";
            int minLength = 8;
            bool expected = false;

            Signup signupClass = new Signup();
            bool isValidLength = signupClass.IsValidPasswordLength(password, minLength);
            
            Assert.AreEqual(expected, isValidLength, "Password length is invalid.");
        }        

        [TestMethod]  
        public void FormValidationTest()
        {
            string name = "dksf";
            string email = "dasd";
            string password = "asd";
            string confirmPass = "asd";

            Signup signupClass = new Signup();
            bool isEmpty = signupClass.IsFormFilled(name, email, password, confirmPass);

            bool expected = false;

            Assert.AreEqual(expected, isEmpty, "Form belum selesai diisi.");
        }
    }
}