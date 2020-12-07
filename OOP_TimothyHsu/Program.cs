using OOP_TimothyHsu.Models;
using System;

namespace OOP_TimothyHsu
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTPROGRAMMA
            Adres adresJos = new Adres() { Gemeente = "Humbeek", HuisNr = "12", Postcode = 1851, Straat = "Kerkstraat" };
            Adres adresAn = new Adres() { Gemeente = "Vilvoorde", HuisNr = "50", Postcode = 1800, Straat = "Mechelsesteenweg" };
            Adres adresCharles = new Adres() { Gemeente = "Aalst", HuisNr = "21", Postcode = 9300, Straat = "Dirk Martensstraat" };
            Adres neckermannAdres = new Adres() { Gemeente = "Brussel", HuisNr = "123", Postcode = 1000, Straat = "Rue Neuve" };
            Adres tuiAdres = new Adres() { Gemeente = "Mechelen", HuisNr = "22", Postcode = 2800, Straat = "Guldenstraat" };
            Persoon jos = new Persoon() {Voornaam = "Jos", Familienaam = "Janssens", Adres = adresJos };
            Persoon an = new Persoon() { Voornaam = "An", Familienaam = "Peters", Adres = adresAn };
            Persoon charles = new Persoon() { Voornaam = "Charles", Familienaam = "Dubois", Adres = adresCharles };
            Reisbureau neckermann = new Reisbureau() { Adres = neckermannAdres, Naam = "Neckermann"};
            Reisbureau tui = new Reisbureau() { Adres = tuiAdres, Naam = "TUI"};
            Autovakantie vakantieJos = new Autovakantie(6,new DateTime(2021,2,14), new DateTime(2021, 3, 5),false);
            VliegtuigVakantie vakantieAn = new VliegtuigVakantie(4, new DateTime(2021, 5, 23), new DateTime(2021, 6, 11),325d);
            Cruise vakantieCharles = new Cruise(2, new DateTime(2021, 1, 25), new DateTime(2021, 2, 20),true);
            ReisReservatie reservatieJos = new ReisReservatie(jos,vakantieJos,neckermann);
            ReisReservatie reservatieAn = new ReisReservatie(an, vakantieAn, neckermann);
            ReisReservatie reservatieCharles = new ReisReservatie(charles, vakantieCharles, tui);

            foreach (var item in LoggerService.Logs)//The entire log is shown on the console
            {
                Console.WriteLine(item);
            }
        }
    } 
}
