using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool value = true;
            Assert.IsTrue(value);
        }
    }
}
