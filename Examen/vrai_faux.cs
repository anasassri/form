using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class vrai_faux : Reponse 
    {
        Q_Dichotomique question;
        string reponse { get; set; }
        vrai_faux(Q_Dichotomique question , int id , string reponse) : base(id,question) {

            this.reponse = reponse; 
        }
    }
}
