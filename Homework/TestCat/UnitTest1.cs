using HomeWork_w9_ex2;
namespace TestCat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { }
            public Cat cat = new Cat();
        
        [TestMethod]
        public void TestMethod_Summer_Temp_40()
        {
            bool result = cat.CatIsPlaying(true, 40);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_Winter_Temp_40()
        {
            bool result = cat.CatIsPlaying(false, 40);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_Summer_Temp_10()
        {
            bool result = cat.CatIsPlaying(true, 10);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_Winter_Temp_10()
        {
            bool result = cat.CatIsPlaying(false, 10);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_Winter_Temp_25()
        {
            bool result = cat.CatIsPlaying(false, 25);
            Assert.IsFalse(result);
        }
    }
}
    
