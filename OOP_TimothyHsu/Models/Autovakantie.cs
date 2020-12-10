using System;

namespace OOP_TimothyHsu.Models
{
    public class Autovakantie : Reis
    {
        private const double EXTRAPRIJSHUURAUTO = 10;
        public bool EigenWagen { get; private set; }
        public Autovakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum, bool eigenWagen) : base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            EigenWagen = eigenWagen;
        }
        public override double BerekenPrijs()
        {
            if (EigenWagen)
            {
                return base.BerekenPrijs();
            }
            else
            {
                if (AantalPersonen<=5)//only 5 persons will fit in a car
                {
                    return base.BerekenPrijs() + (AantalDagen * EXTRAPRIJSHUURAUTO);
                }
                else
                {
                    int extraCar = 0;
                    if (AantalPersonen%5!=0)
                    {
                        extraCar = 1;
                    }
                    double amountOfCars = (AantalPersonen - AantalPersonen % 5)/5 + (double)extraCar;
                    return base.BerekenPrijs() + (AantalDagen * EXTRAPRIJSHUURAUTO * amountOfCars);
                } 
            }
        }
    }
}
