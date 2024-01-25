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
        public DateTime DataDiNascita { get; set; }

        public Persona() { }
        public Persona(int AnnoDiNascita)
        {
            this.AnnoDiNascita = AnnoDiNascita;
        }

        public int AnniPassati()
        {
            return DateTime.Now.Year - AnnoDiNascita;
        }

        public int CalcolaEta()
        {
            int eta = AnniPassati();
            if (DataDiNascita.Month > DateTime.Now.Month)
                return eta - 1;
            else if (DataDiNascita.Month == DateTime.Now.Month)
            {
                if (DataDiNascita.Day < DateTime.Now.Day)
                    return eta;
                else
                    return eta - 1;
            }
            else
                return eta;
        }
    }
}
