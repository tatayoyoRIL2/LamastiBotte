using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (reponseList.Contains(userMessage))
            {
                return questionsList[reponseList.FindIndex(a => a.Contains(userMessage))];
            }
            else
            {
                return questionsList[2];
            }
        }
    }
}
