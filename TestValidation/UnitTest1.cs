using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace TestValidation
{
    [TestClass]
    public class UnitTest1
    {
      //  public string firstName="Radhika";

        //RegexSample regexSample;


        [TestInitialize]
        //public void Setup()
        //{
         //regexSample = new RegexSample();
       //}
       
       [DataTestMethod]
       [DataRow("Radhika","Radhika")]
       [DataRow("Ra",null)]
        public void ValidatingFirstName(string firstName,string expected)
        {
            //string expected = "Radhika";
           // RegexSample regexSample = new RegexSample();
            var actual = RegexSample.ValidatingFirstName(firstName);
            Assert.AreEqual(expected, actual);
        }
    }
}
