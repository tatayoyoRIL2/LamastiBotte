using LamastiBotte.Core.Service;
using NUnit.Framework;

namespace Tests
{
    public class ServiceToolTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FormatMessageTest()
        {
            Assert.AreEqual("HELLO", ServiceTool.FormatMessage("HELLO"));
            Assert.AreEqual("HELLO", ServiceTool.FormatMessage("HELLO§"));
            Assert.AreEqual("HELLO", ServiceTool.FormatMessage("HELLO!!!!"));
        }
    }
}