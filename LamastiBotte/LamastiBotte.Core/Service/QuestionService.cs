using System.Collections.Generic;

namespace LamastiBotte.Core.Service
{
    /// <summary>
    /// Créer un <see cref="QuestionService"/>
    /// </summary>
    public static class QuestionService
    {

        /// <summary>
        /// SendResponse pour la réponse utilisateur
        /// </summary>
        public static string SendResponse(string question, List<string> questionsList, List<string> reponseList)
        {
            if (question == "")
            {
                return questionsList[1];
            }
            else if (reponseList.Contains(question))
            {
                return questionsList[reponseList.FindIndex(a => a.Contains(question))];
            }
            else
            {
                return questionsList[1];
            }
        }
    }
}
