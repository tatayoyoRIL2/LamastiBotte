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
            Assert.AreEqual("hello", ServiceTool.FormatMessage("HELLO�"));
            Assert.AreEqual("hello", ServiceTool.FormatMessage("HELLO!!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("HELLO LE MONDE !!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE!!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE   !!!!"));
            Assert.AreEqual("hello le monde", ServiceTool.FormatMessage("   HELLO LE MONDE   "));
        }

        [Test]
        public void FormatOutputMessageTest()
        {
            Assert.AreEqual("Je suis d'accord.", ServiceTool.FormatOutputMessage("je suis d'accord"));
            Assert.AreEqual("Tristan aime les fleurs.", ServiceTool.FormatOutputMessage("tristan aime les fleurs"));
            Assert.AreEqual("Coucou.", ServiceTool.FormatOutputMessage("coucou"));
            Assert.AreEqual("A.", ServiceTool.FormatOutputMessage("a"));
            Assert.AreEqual("A.", ServiceTool.FormatOutputMessage("a"));
        }

    }
}