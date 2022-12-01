using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class etudiant

    {
        public string CIN { get; set; }
        public string nom { get; set; }
        public string Prenom { get; set; }

        private Prestation prestation; // La prestation d'un etudiant  qui a passé un examen

        public etudiant() { }
        public etudiant(string CIN, string nom, string Prenom)
        {
            this.CIN = CIN;
            this.nom = nom;
            this.Prenom = Prenom;
        }

        public void setprestation(List<Reponse> prestation)
        {
            this.prestation = new Prestation(prestation);
        }
        public Prestation getprestation()
        {
            return prestation;

        }
    }
}
