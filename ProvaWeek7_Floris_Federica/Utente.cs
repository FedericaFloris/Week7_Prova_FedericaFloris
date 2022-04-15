using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal class Utente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public Utente()
        {

        }

        public Utente(string nome,string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
    }
}
