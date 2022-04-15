using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal class Insegnante : Persona
    {
        public int AnniDiServizio { get; set; }


        public Insegnante()
        {

        }

        public Insegnante(string nome,string cognome,DateTime dataDinascita,int anniDiServizio)
            : base(nome, cognome, dataDinascita)
        {
            AnniDiServizio = anniDiServizio;
        }

        public override string ToString()
        {
            return base.ToString() + $" Anni di servizio: {AnniDiServizio}";
        }
    }
}
