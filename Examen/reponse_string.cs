﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class reponse_string : Reponse
    {
       
        public string response_ouverte { get; set; }
        Q_ouverte question;
        public  reponse_string(string reponse_ouverte, Q_ouverte question,int id) :base(id,question)
        {
            this.response_ouverte = reponse_ouverte;

        }

    }
}
