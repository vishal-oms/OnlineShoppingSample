using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication4.DomainModels; 
using WebApplication4.Services;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            IAgentContract concreteAgent = new ConcreteAgent();
            ConcreteProduct entity = new ConcreteProduct(concreteAgent);
            //Act
            string result1 = entity.GenerateSlip();
            string result2 = concreteAgent.Commission();
            //Assert
            Assert.IsTrue(result1.Contains("Slip generated..."));
            Assert.IsTrue(result2.Contains("Commission generated..."));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            IAgentContract concreteAgent = new ConcreteAgent();
            Book entity = new Book(concreteAgent);
            //Act
            string result1 = entity.GenerateDulpicateSlip();
            string result2 = concreteAgent.Commission();
            //Assert
            Assert.IsTrue(result1.Contains("Duplicate Slip generated..."));
            Assert.IsTrue(result2.Contains("Commission generated..."));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            IEMail concreteEmail = new ConcreteEMail();
            ConcreteMember entity = new ConcreteMember(concreteEmail);
            //Act
            string result1 = entity.ActivateMember();
            string result2 = concreteEmail.SendEmail();
            //Assert
            Assert.IsTrue(result1.Contains("Member activated..."));
            Assert.IsTrue(result2.Contains("Email sent..."));
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            ConcreteVideo entity = new ConcreteVideo();
            //Act
            string result1 = entity.GeneratePackagingSlip();
            //Assert
            Assert.IsTrue(result1.Contains("Packaging Slip generated..."));
        }
    }
}
