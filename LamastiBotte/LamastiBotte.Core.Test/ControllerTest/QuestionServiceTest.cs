using LamastiBotte.Core.Service;
using NUnit.Framework;

namespace LamastiBotte.Core.Test.ControllerTest
{
    public class QuestionServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SendResponseTest()
        {
            Assert.AreEqual("Je n'ai pas compris ta question !",
                QuestionService.SendResponse("&8&8&9895656166656s6dqds16qsd&édazdazdza"));
        }
    }
}
