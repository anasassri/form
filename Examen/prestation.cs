using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Prestation
    {
        private List<Reponse> prestation; // chaque prestation est compose d'un ensemble de reponse
        private etudiant candidate { get; set; } //chaque prestation appartient a un candidat 

        //  l'ensemble des réponses aux questions constituant l'examen
        public Prestation(List<Reponse> prestation)
        {
         
            this.prestation = prestation;
        }

    }
}
