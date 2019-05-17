using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Model.Entities
{
    /// <summary>
    /// Créer une <see cref="Reponse"/>
    /// </summary>
    public class Reponse
    {
        /// <summary>
        /// Identifiant unique de la reponse
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// String de la reponse
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Liaison entre la réponse et la question
        /// </summary>
        public List<Question> Questions { get; set; }
    }
}
