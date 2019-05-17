using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Model.Entities
{
    public class Reponse
    {
        public uint Id { get; set; }
        public string ReponseString { get; set; }
        public List<Question> Questions = new List<Question>();
    }
}
