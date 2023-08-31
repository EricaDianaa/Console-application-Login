using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_4
{
    public class Ordini
    {
        private double _saldo = 0;
            public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public static List<menuList> ListaProdotti { get; set; } = new List<menuList>();

        public void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("       -------MENU-------            ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("1:  Coca Cola 150 ml(€ 2.50) ");
            Console.WriteLine("2:  Insalata di pollo(€ 5.20)");
            Console.WriteLine("3:  Pizza Margherita(€ 10.00)");
            Console.WriteLine("4:  Pizza 4 Formaggi(€ 12.50)");
            Console.WriteLine("5:  Pz patatine fritte(€ 3.50)");
            Console.WriteLine("6:  Insalata di riso(€ 8.00)");
            Console.WriteLine("7:  Frutta di stagione(€ 5.00)");
            Console.WriteLine("8:  Pizza fritta(€ 5.00)");
            Console.WriteLine("9:  Piadina vegetariana(€ 6.00)");
            Console.WriteLine("10: Panino Hamburger(€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");

            Console.WriteLine("Seleziona prodotti");
            double scelta = Convert.ToDouble(Console.ReadLine());

            if (scelta == 1)
            {
                
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Coca Cola 150 ml";
                menu.Costo = 2.50;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
            
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto+" "+ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 2)

            {
                menuList menu1 = new menuList();
                Console.WriteLine(" ");
                menu1.NomeProdotto = " Insalata di pollo";
                menu1.Costo = 5.20;
                ListaProdotti.Add(menu1);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu1.Costo;
                Main();
            }
            else if (scelta == 3)
            {

                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = " Pizza Margherita";
                menu.Costo = 10.00;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 4)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = " Pizza 4 Formaggi";
                menu.Costo = 12.50;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 5)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = " Pz patatine fritte";
                menu.Costo = 3.50;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Console.WriteLine("Il tuo costo finale è" + _saldo);
                Main();
            }
            else if (scelta == 6)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Insalata di riso";
                menu.Costo = 8.00;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 7)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Frutta di stagione";
                menu.Costo = 5.00;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();

            }
            else if (scelta == 8)
            {
                Ordini list = new Ordini();
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Pizza fritta";
                menu.Costo = 5.00;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 9)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Piadina vegetariana";
                menu.Costo = 6.00;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 10)
            {
                menuList menu = new menuList();
                Console.WriteLine(" ");
                menu.NomeProdotto = "Panino Hamburger";
                menu.Costo = 7.90;
                ListaProdotti.Add(menu);
                Console.WriteLine("Prodotto aggiunto alla lista: ");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                _saldo += menu.Costo;
                Main();
            }
            else if (scelta == 11)
            {
                Console.WriteLine("Lista prodotti acquistati");
                for (int i = 0; i < ListaProdotti.Count; i++)
                {
                    Console.WriteLine(ListaProdotti[i].NomeProdotto + " " + ListaProdotti[i].Costo);
                }
                Console.WriteLine("Il tuo costo finale è" + _saldo);
                Main();
            }
            else if (scelta == 12)
            {

                Console.WriteLine("Chiusura programma in corso");
                Environment.Exit(0);
            }
        }
    }
    public class menuList
    {
        public string NomeProdotto { get; set; }
        public double Costo { get; set; }
    }
}
