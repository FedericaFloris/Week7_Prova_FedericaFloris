using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal class UtenteNonTrovatoException : Exception
    {
        public Utente  Nome { get; set; }

        public Utente Cognome { get; set; }

        public UtenteNonTrovatoException()
        {

        }

        public UtenteNonTrovatoException(string messagio) : base(messagio)
        {

        }

        protected UtenteNonTrovatoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
}
