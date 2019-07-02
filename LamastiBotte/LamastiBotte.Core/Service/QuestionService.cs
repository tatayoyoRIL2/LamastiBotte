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
        public static string SendResponse(string question)
        {
            List<string> questionsList = new List<string>();
            List<string> reponseList = new List<string>();

            string returnString = "";
            if (questionsList.Contains(question))
            {
                returnString = "Value NOT found into datas.";
            }
            else if(question == "")
            {
                returnString = "Ta réponse est vide !";
            }
            else
            {
                questionsList.Add(question);
                returnString = "Je n'ai pas compris ta question !";
            }
            return returnString;
        }
    }
}
