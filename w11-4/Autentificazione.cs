using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w11_4;

namespace w11_4
{
    public static  class Autentificazione
    {
        public static string Username;
 
        private static bool _utenteLogin = false;
        public static bool UtenteLogin

        {
            get { return _utenteLogin; }
            set { _utenteLogin = value; }
        }
        public static DateTime DataOra { get; set; }
        public static List<DateTime> VerificaLogin { get; set; }=new List<DateTime> ();

        public static  void Menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("       -------OPERAZIONI-------      ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Scegli un operazione da effettuare");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Logout");
            Console.WriteLine("3: Verifica ora e data di login");
            Console.WriteLine("4: Lista degli acessi");
            Console.WriteLine("5: Ecsi");

            double scelta = Convert.ToDouble(Console.ReadLine());
            if (scelta == 1)
            {
                if (UtenteLogin == false)
                {
                   
                    Console.WriteLine(" ");
                    Console.WriteLine("Inserisci username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Inserisci password");
                    string password = Console.ReadLine();
                    Console.WriteLine("Inserisci confermapassword");
                    string confermaPassword = Console.ReadLine();
                    UtenteLogin = true;
                    if ( username != null && password == confermaPassword)
                    {
                        DateTime date = DateTime.Now;

                        Username = username;
                        Console.WriteLine("Utente correttamente loggato alle ore " + date);
                        VerificaLogin.Add(date);

 
                    }
                    else
                    {
                        Console.WriteLine("Password e confermapassword non concidono riprovare");
                    }
                }
                else
                {
                    Console.WriteLine("Hai gia effetuato il login");
                }

                Menu();
            }
            else if (scelta == 2)
            {
                if (UtenteLogin == true)
                {
                    UtenteLogin = false;
                    DateTime date = DateTime.Now;
                    Console.WriteLine("L'utente ha effetuato il logout alle ore " + date);
                    Menu();

                }
                else
                {
                    Console.WriteLine("Non puoi effetuare un logout se non hai effetuato un login in precedenza");
                    Menu();
                }

            }
            else if (scelta == 3) 
            {
                if (UtenteLogin == true)
                {
                DateTime dateTime = VerificaLogin.Last();
                Console.WriteLine("L'utente ha effetuato il login alle ore " +dateTime);
                }
                else
                {
                    Console.WriteLine("Nessun utente loggato");
            
                }
               


                Menu();
            }
            else if (scelta == 4)
            {
               
                    for (int i = 0; i < VerificaLogin.Count; i++)
                    {
                    Console.WriteLine($"{Username} ha effettuato l'accesso il " + VerificaLogin[i]);
                    }
               
                
                Menu();
            }
            else if (scelta == 5)
            {

                Console.WriteLine("Chiusura programma in corso");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Errore nessuna operazione scleta");
                Menu();
            }

        }

      
    } 

}

