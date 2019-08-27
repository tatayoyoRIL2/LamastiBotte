using LamastiBotte.Core.Service;
using NUnit.Framework;
using System.Collections.Generic;

namespace LamastiBotte.Core.Test.ControllerTest
{
    public class QuestionServiceTest
    {
        public List<string> questionsList;
        public List<string> reponseList;

        [SetUp]
        public void Setup()
        {
            questionsList = new List<string> { "bonjour", "je vous écoute" };
            reponseList = new List<string> { "salut", "tu m'écoute" };
        }

        [Test]
        public void SendResponseTestEmpty()
        {
            Assert.AreEqual(questionsList[1],
                QuestionService.SendResponse("", questionsList, reponseList));
        }

        [Test]
        public void SendResponseTestBadWord()
        {
            Assert.AreEqual(questionsList[1],
                QuestionService.SendResponse("$!yoann! aime !aller au wc456456654!!", questionsList, reponseList));
        }

        [Test]
        public void SendResponseTestReponse()
        {
            Assert.AreEqual(questionsList[0],
                QuestionService.SendResponse(reponseList[0], questionsList, reponseList));
        }
    }
}
