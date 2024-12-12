using System;

namespace Firma.Personeel;

public abstract class Werknemer : IKost
{

    public bool Menselijk
    {
        get => true;
    }
    public abstract decimal BerekenKostprijs();


    public static DateOnly Personeelsfeest { get; set; }
    private static DateOnly personeelsfeest
    {
        set => personeelsfeest = value;
        get => personeelsfeest;
    }

    private string? naam;
    public string Naam

    {
        get
        {
            return naam!;
        }
        set
        {
            if (value != string.Empty)
            {
                naam = value;
            }
        }


    }
    public DateTime InDienst { get; set; }
    private Geslacht geslacht;
    public Geslacht Geslacht
    { get => geslacht; set => geslacht = value; }

    private decimal salaris;
    public decimal Salaris
    {
        get => salaris;

        private set
        {
            if (value >= 0m)
            {
                salaris = value;
            }
        }
    }
    public bool VerjaarAncien
    {
        get
        {
            return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
        }
    }





    public int? AantalKinderen { get; set; }
    public bool? Gehuwd { get; set; }
    //virtual make it accessible in another class to do override
    public virtual string GetInfo()
    {
        return $"Naam: {Naam}\n" +
         $"Geslacht: {Geslacht}\n" +
         $"InDienst: {InDienst}\n" +
         $"Personeelsfeest: {Personeelsfeest}";
    }

    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
    {

        Naam = naam;
        InDienst = inDienst;
        Geslacht = geslacht;

    }


    public override int GetHashCode()
    {
        // return Naam.GetHashCode();
        return HashCode.Combine(Naam);

    }


    public void TekenLijn(int lengte, char teken)
    {
        for (int teller = 0; teller < lengte; teller++)
            Console.Write(teken);
        Console.WriteLine();
    }
    public void TekenLijn(int lengte)
    {
        TekenLijn(lengte, '-');
    }
    public void TekenLijn()
    {
        TekenLijn(79);
    }


    public WerkRegime? Regime { get; set; }

    public class WerkRegime
    {
        public enum RegimeType
        {
            Voltijds,
            Viervijfde,
            Halftijds
        }

        public required RegimeType Type { get; set; }

        public int AantalVacantiedagen
        {
            get
            {
                return Type switch
                {
                    RegimeType.Voltijds => 25,
                    RegimeType.Viervijfde => 20,
                    RegimeType.Halftijds => 12,
                    _ => 0
                };
            }
        }


        public override string ToString()
        {
            return Type.ToString();
        }

    }

}

