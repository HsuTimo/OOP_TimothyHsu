using OOP_TimothyHsu.Interfaces;

namespace OOP_TimothyHsu.Models
{
    public class ReisReservatie : ILoggable
    {
        public LogMessage LogMessage 
        { 
            get 
            { 
                return new LogMessage
                    (
                    "\nNieuwe reservatie:" +
                    $"\nNaam: {Persoon.Naam}" +
                    $"\nAdres:\n{Persoon.Adres.Straat} {Persoon.Adres.HuisNr}" +
                    $"\n{Persoon.Adres.Postcode} {Persoon.Adres.Gemeente}\n"+
                    $"\nReisbureau: {Reisbureau.Naam}" +
                    $"\nAdres:\n{Reisbureau.Adres.Straat} {Reisbureau.Adres.HuisNr}" +
                    $"\n{Reisbureau.Adres.Postcode} {Reisbureau.Adres.Gemeente}\n" +
                    $"\nReisgegevens:\n{Reis}"
                    ); 
            } 
        }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }
        public ReisReservatie(Persoon persoon, Reis reis, Reisbureau reisBureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisBureau;
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}
