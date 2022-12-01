using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Q_ouverte : Question
    {


        private reponse_string reponse; //reponse d'etudiant 
        public Q_ouverte(string Ques, int Id , float Note) : base(Ques, Id, Note) { }
    }
}
