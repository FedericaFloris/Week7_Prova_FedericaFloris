using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public DateTime DataDiNascita { get; set; }

        public Persona()
        {

        }

        public Persona(string nome,string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Cognome: {Cognome} - Data di nascita: {DataDiNascita}";
        }
    }
}
