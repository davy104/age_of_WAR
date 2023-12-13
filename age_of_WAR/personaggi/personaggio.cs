using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_WAR.personaggi
{
    public abstract class Personaggio
    {
        public int Puntivita { get; set; }
        public int Puntiforza { get; set; }
        public int Velocita { get; set; }
        public int Puntidifesa { get; set; }
        public string Squadra { get; set; }
    }
}
