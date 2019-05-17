using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Model.Entities
{
    /// <summary>
    /// Créer une <see cref="Question"/>
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Identifiant unique de la question
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// String de la question
        /// </summary>
        public string QuestionString { get; set; }

        /// <summary>
        /// Liaison entre la question et réponse
        /// </summary>
        public List<Reponse> reponses = new List<Reponse>();
    }
}
