using System;
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
        public static string SendResponse(string userMessage, List<string> questionsList, List<string> reponseList)
        {
            if (userMessage == "" || userMessage == null)
            {
                return questionsList[1];
            }
            else if (questionsList.Contains(userMessage))
            {
                return reponseList[questionsList.FindIndex(a => a.Contains(userMessage))];
            }
            else
            {
                return questionsList[2];
            }
        }
    }
}
