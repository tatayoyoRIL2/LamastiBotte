using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Model.Entities
{
    public class Question
    {
        public uint Id { get; set; }
        public string QuestionString { get; set; }
        public List<Reponse> reponses = new List<Reponse>();
    }
}
