using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal class RepositoryMockUtente
    {
        public List<Utente> utenti = new List<Utente>
        {
            new Utente("Federica", "Floris"),
            new Utente("Mario", "Rossi")
        };



        public void CercaUtente(string nome, string cognome)
        {
            try
            {
                foreach (var item in utenti)
                {
                    if (nome == item.Nome && cognome == item.Cognome)
                    {
                        Console.WriteLine("Utente trovato");
                        return;
                    }


                }
                throw new UtenteNonTrovatoException($"Errore Utente {nome} {cognome} non trovato");
              
            }
            catch (UtenteNonTrovatoException c)
            {
                Console.WriteLine(c.Message);
            }
        }


    }
}

