using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_WAR.personaggi
{
    
    public class Cavaliere:Personaggio
    {
        public Cavaliere(int puntiforza)
        {
            Puntivita = 1000;
            Puntiforza += puntiforza;
        }
       
    }
}
