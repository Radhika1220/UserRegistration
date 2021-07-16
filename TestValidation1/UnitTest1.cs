using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace TestValidation1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Radhika", "Radhika")]
        [DataRow("Rad", "Rad")]
        [DataRow("r", null)]

        public void ValidateFirstname(string a, string expected)
        {

            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Shankar", "Shankar")]
        [DataRow("Sha", "Sha")]
        [DataRow("Sh", null)]

        public void ValidateLastname(string a, string expected)
        {

            var actual = RegexSample.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]
        [DataRow("abc@abc@gmail.com", null)]

        public void ValidateEmailId(string a, string expected)
        {

            var actual = RegexSample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 7852234896","91 7852234896")]
        [DataRow("91@123", null)]
        [DataRow("A865", null)]

        public void ValidatePhoneNumber(string a, string expected)
        {

            var actual = RegexSample.ValidatingPhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Radhika@12", "Radhika@12")]
        [DataRow("sumAthi_32", "sumAthi_32")]
        [DataRow("Priya123", null)]
        [DataRow("praveena", null)]

        public void ValidatePassword(string a, string expected)
        {

            var actual = RegexSample.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
        