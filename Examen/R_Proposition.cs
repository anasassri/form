using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class R_Proposition : Reponse
    {
        private List<Reponse> propositions = new List<Reponse>(); // liste de reponse d'etudaint
        private Certitude Certitude { get; set; } //Pour les QCM il est possible de demander le degré de certitude
        private QCM question; 
        public R_Proposition(List<Reponse> propositions,int id,Question ques) : base(id,ques)
        {
            this.propositions = propositions;
            
        }
    }
}
