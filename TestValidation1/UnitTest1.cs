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
            try
            {
                var actual = RegexSample.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        [TestMethod]
        [DataRow("Shankar", "Shankar")]
        [DataRow("Sha", "Sha")]
        [DataRow("Sh", null)]

        public void ValidateLastname(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
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
            try
            {
                var actual = RegexSample.ValidatingEmailId(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        [TestMethod]
        [DataRow("91 7852234896", "91 7852234896")]
        [DataRow("91@123", null)]
        [DataRow("A865", null)]

        public void ValidatePhoneNumber(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPhoneNum(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        [TestMethod]
        [DataRow("Radhika@12", "Radhika@12")]
        [DataRow("sumAthi_32", "sumAthi_32")]
        [DataRow("Priya123", null)]
        [DataRow("praveena", null)]

        public void ValidatePassword(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        [TestMethod]
        public void Test_Method_Object_Creation_RegexSample()
        {
            object expected = new RegexSample();
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSample");
            expected.Equals(actual);

        }
        //Test for parameterconstructor invoked using object created
        [TestMethod]
        public void Test_Method_Parameteized_Constructor()
        {
            object expected = new RegexSample("RegularExpression");
            UserRegistrationFactory factory = new UserRegistrationFactory();
            object actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSample", "RegularExpression");
            actual.Equals(expected);
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "No constructor found";
            object obj = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSam");

            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "No class found";
            object obj = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSae", "RegexSample");

            }
            catch (CustomizedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No class found";
            object actual = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSae", "RegexSample", message);

            }
            catch (CustomizedException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor_Invalid()
        {
            string message = "Regular Expression";
            string expected = "No constructor found";
            object actual = null;
            try
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSam", message);

            }
            catch (CustomizedException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
    }
}

        