using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myapp.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = myapp.Program.Dummy();
            Assert.AreEqual("JP", a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = myapp.Program.Dummy2();
            Assert.AreEqual("JP2", a);
        }
    }
}
