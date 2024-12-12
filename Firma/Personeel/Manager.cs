using System;

namespace Firma.Personeel;

public class Manager : Bediende
{
    private decimal bonus;
    public decimal Bonus
    {
        get => bonus;
        set
        {
            if (value > 0m)
            {
                bonus = value;
            }
        }

    }
    public Manager(string naam, DateTime indienst, Geslacht geslacht, decimal wedde, decimal bonus) : base(naam, indienst, geslacht, wedde)
    {
        Bonus = bonus;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Bonus: {Bonus}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} Bonus: {Bonus}";
    }
    public override decimal BerekenKostprijs()
    {
        return base.BerekenKostprijs() + Bonus;
    }


}


