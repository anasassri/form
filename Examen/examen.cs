using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen
{
    internal class Examen
    {
        public string Intitule { get; set; }   //Un examen a un intitulé
        public float Duree { get; set; }  
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin{ get; set; }
       
        public List<Question> Ques = new List<Question>();   //Un examen contient des questions

        Examen(string Intitule , float Duree , DateTime Date_debut, DateTime Date_fin )
        {
            this.Duree = Duree; 
            this.Date_debut = Date_debut;   
            this.Date_fin = Date_fin;   
            this.Intitule = Intitule;
         
        }

        public List<Question> GetQuestionsList()
        {
            return Ques;
        }

        public void SetQuestionsList(List<Question> Ques)
        {
            this.Ques = Ques;
        }
    }
    // ajouter une nouvelle Question 
    // modifier une Question 
    //supprimer une question 
    //ouverture d'un examen 
    //fermeture d'un examen








}
}
     
    