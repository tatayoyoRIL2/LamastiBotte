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
            Assert.AreEqual("hello", ServiceTool.FormatMessage("HELLO"));
            Assert.AreEqual("hello", ServiceTool.FormatMessage("HELLO§"));
            Assert.AreEqual("hello", ServiceTool.FormatMessage("HELLO!!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("HELLO LE MONDE !!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE!!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE   !!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE   "));
        }
    }
}