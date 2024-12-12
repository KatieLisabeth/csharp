
namespace Firma.Materiaal
{
    public class Fotokopiemachine : IKost
    {
        private int aantalGekopieeerdeBlz;
        public int AantalGekopieeerdeBlz
        {
            get => aantalGekopieeerdeBlz;
            set
            {
                if (value >= 0)
                    aantalGekopieeerdeBlz = value;

            }
        }
        private decimal kostPerBlz;
        public decimal KostPerBlz
        {
            get => kostPerBlz;
            set
            {
                if (value > 0)
                    kostPerBlz = value;
            }
        }
        public string SerieNr { get; init; }

        public Fotokopiemachine(string serieNr, int aantalGekopieeerdeBlz, decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieeerdeBlz = aantalGekopieeerdeBlz;
            KostPerBlz = kostPerBlz;
        }
        public bool Menselijk => false;
        public decimal BerekenKostprijs() => AantalGekopieeerdeBlz * KostPerBlz;

    }
}