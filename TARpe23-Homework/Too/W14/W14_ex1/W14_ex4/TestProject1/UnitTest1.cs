using W14_ex4;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program Pro = new Program();
        [TestMethod]
        public void TestMethod1()
        {
            bool result = Pro.manipulation("juhan.juurikas@company.eu");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod2() 
        {
            bool result = Pro.createMail();
            Assert.IsFalse(result);
        }
    }
}