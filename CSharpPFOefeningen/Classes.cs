using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus;
public enum Geslacht
{
    Man, Vrow, X
}

public class Werknemer
{
    // Personeelsfeest

    public static DateOnly Personeelsfeest { get; set; }
    private static DateOnly personeelsfeest
    {
        set => personeelsfeest = value;
        get => personeelsfeest;
    }

    //Naam
    private string? naam;
    public string Naam

    {
        get
        {
            return naam!;
        }
        // init //Init-only property or indexer 'Werknemer.Naam' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.
        // init => naam = !string.IsNullOrWhiteSpace(value) ? value : "onbekende naam";
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
    // int? aantalKinderen = null;
    // bool? gehuwd;
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
    // [SetsRequiredMembers]
    public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man) { }
    // public Werknemer()
    // {

    //     Naam = "Onbekend";
    //     InDienst = DateTime.Today;
    //     Geslacht = Geslacht.Man;

    // }
    //[SetsRequiredMembers]
    public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
    {

        Naam = naam;
        InDienst = inDienst;
        Geslacht = geslacht;

    }

    public override string ToString()
    {
        return $"{Naam} {Geslacht}";
    }
    public override bool Equals(object? obj)
    {
        // if (obj is Werknemer)
        // {
        //     Werknemer deAndere = (Werknemer)obj;
        //     return this.Naam == deAndere.Naam;
        // }
        // else return false;
        return obj is Werknemer werknemer && Naam == werknemer.Naam;
    }

    public override int GetHashCode()
    {
        // return Naam.GetHashCode();
        return HashCode.Combine(Naam);

    }

}
public class LijnenTrekker
{
    // public void TekenLijn(int lengte)
    // {
    //     for (int teller = 0; teller < lengte; teller++)
    //         Console.Write("-");
    //     Console.WriteLine();
    // }
    // public void TekenLijn(int lengte, char teken)
    // {
    //     for (int teller = 0; teller < lengte; teller++)
    //         Console.Write(teken);
    //     Console.WriteLine();
    // }

    //Overloading
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
}

public class Omzetter
{
    public const double CentimeterPerInch = 2.54;
    public double CmNaarInch(double cm) => cm / CentimeterPerInch;
    public double InchNaarCm(double inch) => inch * CentimeterPerInch;

}

public class Verwisselaar
{
    public void Verwissel(ref int getal1, ref int getal2)
    {
        int tussen = getal1;
        getal1 = getal2;
        getal2 = tussen;
    }
}


public class Werknemer2(string naam, DateTime indienst, Geslacht geslacht)
{
    public string Naam { get; set; } = !string.IsNullOrWhiteSpace(naam) ? naam : "Onbekend";
    public DateTime InDienst { get; set; } = indienst;
    public Geslacht Geslacht { get; set; } = geslacht;

    public bool VerjaarAncien
    {
        get { return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day; }
    }
    public string GetInfo()
    {
        return $"Naam: {Naam}\n" +
        $"Geslacht: {Geslacht}\n" +
        $"InDienst: {InDienst}\n";
    }
}

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

}

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


}

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



}