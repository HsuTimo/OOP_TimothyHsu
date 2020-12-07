using System;

namespace OOP_TimothyHsu.Models
{
    public class VliegtuigVakantie:Reis 
    {
        public double VliegtuigTicketPrijs { get; private set; }
        public VliegtuigVakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum, double vliegtuigTicketPrijs) : base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs()+VliegtuigTicketPrijs;
        }
    }
}
