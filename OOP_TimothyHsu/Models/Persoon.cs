namespace OOP_TimothyHsu.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get { return $"{Voornaam} {Familienaam}"; } }
    }
}
