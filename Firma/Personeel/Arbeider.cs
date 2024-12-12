using System;

namespace Firma.Personeel;

public class Arbeider : Werknemer
{
    private decimal uurloon;
    public decimal Uurloon
    {
        get => uurloon;
        set
        {
            if (value >= 0m)
                uurloon = value;

        }
    }
    private byte ploegenstelsel;
    public byte Ploegenstelsel
    {
        get => ploegenstelsel;
        set
        {
            if (value > 1 && value <= 3)
                ploegenstelsel = value;
        }
    }



    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Uurloon: {Uurloon}\n" +
        $"Ploegenstelsel: {Ploegenstelsel}\n";
    }
    public override string ToString()
    {
        return $"{base.ToString()} {Uurloon} euro/uur";
    }
    public Arbeider(string naam, DateTime indienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) : base(naam, indienst, geslacht)
    {
        Uurloon = uurloon;
        Ploegenstelsel = ploegenstelsel;
    }

    public override decimal BerekenKostprijs()
    {
        return Uurloon * 2000m;
    }

}

