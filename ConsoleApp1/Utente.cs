using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Utente
    { // static => cioè non ha bisogno di avere più istanze
        // n.b.: non si riferisce nè al tipo di dato nè all'essere pubblico/privato
        public static string username;
        private static string password;
        private static bool loggedIn;
        public static DateTime dataLogin; // gestito in login

        //Metodo LOGIN
        public static void Login() {
            Console.WriteLine("\nInserisci username:");
            Utente.username = Console.ReadLine();
            Console.WriteLine("\nInserisci password:");
            Utente.password = Console.ReadLine();
            loggedIn = true; //
            if (loggedIn == true)
            {
                dataLogin = DateTime.Now;
                StampaDataEOraLogin();
            }
        }

        // METODO LOGOUT
        public static void Logout()
        {
            if(loggedIn == true) 
            {
                Console.WriteLine("\nLogout effettuato con successo.");
                loggedIn = false;
                    } else {
                Console.WriteLine("\nNessun utente loggato!");
                    }
        }
        // METODO DATA E ORA
        public static void StampaDataEOraLogin()
        {
            if (loggedIn == true)
            {
                Console.WriteLine($"\nUltimo accesso il: {dataLogin}");
            }
            else
            { Console.WriteLine("\nNessun utente loggato"); }
        }
        // METODO LISTA ACCESSI
        public static void StampaListaAccessi( ) 
        { Console.WriteLine("\nLista accessi non disponibile"); }
    }
}
