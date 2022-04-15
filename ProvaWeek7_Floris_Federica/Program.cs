// See https://aka.ms/new-console-template for more information
using ProvaWeek7_Floris_Federica;

Console.WriteLine("Hello, World!");
//TEORIA:
//1) C-D
//2)B
//3)A-D

//RepositoryInsegnanteAdo repo = new RepositoryInsegnanteAdo();
RepositoryMockUtente tuttiUtenti = new RepositoryMockUtente();

//repo.GetAllTeachers();


Console.WriteLine("Inserisci il nome dell'utente che stai cercando:");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci il cognome dell'utente che stai cercando:");
string cognome = Console.ReadLine();

tuttiUtenti.CercaUtente(nome, cognome);



Console.ReadLine();

