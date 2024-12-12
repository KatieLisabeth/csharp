using System;

namespace Firma.Personeel;

public class Bediende : Werknemer
{
    public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde) : base(naam, indienst, geslacht)
    {
        Wedde = wedde;
    }
    private decimal wedde;
    public decimal Wedde
    {
        get => wedde;
        set
        {
            if (value >= 0m)
            {
                wedde = value;
            }
        }
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Wedde: {Wedde}";
    }
    public override string ToString()
    {
        return $"{base.ToString()} {Wedde} euro/maand";
    }

    public override decimal BerekenKostprijs()
    {
        return Wedde * 12m;
    }


}


