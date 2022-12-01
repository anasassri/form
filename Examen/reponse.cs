using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class  Reponse
    {



        private int id { get; set; } // pour identifier la question 
        private Question question; 
   
        public Reponse (int id , Question question ) 
        {
            this.id = id;
            this.question =  question  ;  
        }
    }
}
