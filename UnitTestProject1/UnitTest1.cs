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
    }
}
