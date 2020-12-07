using System;

namespace OOP_TimothyHsu.Models
{
    public abstract class Reis
    {
        private double BASISDAGPRIJS = 40d;
        private DateTime _vertrekDatum;
        private DateTime _terugkeerDatum;
        public int AantalDagen
        {
            get//No set is used so it's readonly
            {
                TimeSpan timeSpan = TerugkeerDatum - VertrekDatum;
                return timeSpan.Days;
            }
        }
        public int AantalPersonen { get; set; }
        public DateTime VertrekDatum
        {
            get { return _vertrekDatum; }
            set
            {
                if (value < DateTime.Now)//checks if the date is before the current date
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vertrekdatum niet geldig. Ingegeven datum is in het verleden.");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    _vertrekDatum = value;
                }
            }
        }
        public DateTime TerugkeerDatum
        {
            get { return _terugkeerDatum; }
            set
            {
                if (value < DateTime.Now || value < VertrekDatum)//checks if the date is smaller than 'VertrekDatum'
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Terugkeerdatum niet geldig! Ingegeven datum is vroeger dan de vertrekdatum!");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    _terugkeerDatum = value;
                }
            }
        }
        public Reis(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            AantalPersonen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
        public virtual double BerekenPrijs()
        {
            return AantalDagen* BASISDAGPRIJS;
        }
        public override string ToString()
        {
            return $"Aantal personen:{AantalPersonen}\nVertrekdatum: {VertrekDatum.Day}/{VertrekDatum.Month}/{VertrekDatum.Year}" +
                $"\nTerugkeerdatum: {TerugkeerDatum.Day}/{TerugkeerDatum.Month}/{TerugkeerDatum.Year}" +
                $"\nPrijs: {BerekenPrijs()} EUR";
        }
    }
}
