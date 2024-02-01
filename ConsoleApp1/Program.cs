using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char scelta;

            do
            {
                // MENU OPERAZIONI 
                Console.WriteLine("================OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Verifica ora e data di login");
                Console.WriteLine("4. Lista degli accessi");
                Console.WriteLine("5. Esci");
                Console.WriteLine("========================================");
                // FINE MENU

                // Leggi l'input dell'utente
                scelta = Console.ReadKey().KeyChar; // ottiene valore della key

                switch (scelta)
                {
                    case '1':
                        Utente.Login();
                        break;
                    case '2':
                        Utente.Logout();
                        break;
                    case '3':
                        Utente.StampaDataEOraLogin();
                        break;
                    case '4':
                        Utente.StampaListaAccessi();
                        break;
                    case '5':
                        Console.WriteLine("\nArrivederci!");
                        break;
                    default:
                        Console.WriteLine("\nScelta non valida. Il programma si riavvierà.");
                        break;
                }

            } while (scelta != '5'); // Continua fino a quando la scelta non è "Esci" (5)
        }
    }
}