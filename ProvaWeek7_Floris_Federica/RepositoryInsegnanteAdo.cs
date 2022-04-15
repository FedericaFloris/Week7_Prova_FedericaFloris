using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_Floris_Federica
{
    internal class RepositoryInsegnanteAdo
    {
        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ";
        //ho cambiato il catalog da scuola a mare in modo tale che mi entri nel catch sqlExpection
        //l altra catch l ho messa perchè volevo vedere se non mettendo alcuna stringa mi mettesse sempre SqlExpection
        //invece va direttamente li(exception) dicendo che la stringa non è stata inizializzata
        public void GetAllTeachers()

        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();

                    SqlCommand comando = new SqlCommand("select * from Insegnante", connection);


                    SqlDataReader risultato = comando.ExecuteReader();

                    while (risultato.Read())
                    {

                        var nome = (string)risultato["Nome"];
                        var cognome = (string)risultato["Cognome"];
                        var dataDiNascita = (DateTime)risultato["DataDiNascita"];
                        var anniServizio = (int)risultato["AnniServizio"];
                        Insegnante i = new Insegnante(nome, cognome, dataDiNascita, anniServizio);
                        Console.WriteLine(i.ToString());

                        connection.Close();

                    }

                }
            }   
           
            catch(SqlException ex)
            {
                Console.WriteLine($"Problemi con la Connessione al DB, Dettagli: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore generico. Dettagli: {ex}");
                
            }


        }

            
    }
}

