using Microsoft.VisualStudio.TestPlatform.TestHost;
using W14_ex4;
namespace W14_ex4_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestMethod_Summer_Temp_40()
        {
            bool result = manipulation(true, 40);
            Assert.IsFalse(result);
        }
    }
}