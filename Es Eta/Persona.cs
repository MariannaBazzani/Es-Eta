using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Eta
{
    internal class Persona
    {
        public int AnnoDiNascita { get; set; }
        
        public Persona() { }
        public Persona(int AnnoDiNascita)
        {
            this.AnnoDiNascita = AnnoDiNascita;
        }

        public int CalcolaEta(int AnnoDiNascita)
        {
            int Oggi = DateTime.Now.Year;
            int AnniOggi =
            return AnniOggi;
        }
    }
}
