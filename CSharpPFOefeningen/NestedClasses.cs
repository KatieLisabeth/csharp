// using System;


// public enum Geslacht
// {
//     Man, Vrow, X
// }
// public abstract class Werknemer
// {
//     public static DateOnly Personeelsfeest { get; set; }
//     private static DateOnly personeelsfeest
//     {
//         set => personeelsfeest = value;
//         get => personeelsfeest;
//     }

//     //     //Naam
//     private string? naam;
//     public string Naam

//     {
//         get
//         {
//             return naam!;
//         }
//         set
//         {
//             if (value != string.Empty)
//             {
//                 naam = value;
//             }
//         }


//     }
//     public DateTime InDienst { get; set; }
//     private Geslacht geslacht;
//     public Geslacht Geslacht
//     { get => geslacht; set => geslacht = value; }

//     private decimal salaris;
//     public decimal Salaris
//     {
//         get => salaris;

//         private set
//         {
//             if (value >= 0m)
//             {
//                 salaris = value;
//             }
//         }
//     }
//     public bool VerjaarAncien
//     {
//         get
//         {
//             return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
//         }
//     }
//     //     // int? aantalKinderen = null;
//     //     // bool? gehuwd;
//     public int? AantalKinderen { get; set; }
//     public bool? Gehuwd { get; set; }
//     //virtual make it accessible in another class to do override
//     public virtual string GetInfo()
//     {
//         return $"Naam: {Naam}\n" +
//          $"Geslacht: {Geslacht}\n" +
//          $"InDienst: {InDienst}\n" +
//          $"Personeelsfeest: {Personeelsfeest}";
//     }

//     public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
//     {

//         Naam = naam;
//         InDienst = inDienst;
//         Geslacht = geslacht;

//     }


//     public override int GetHashCode()
//     {
//         // return Naam.GetHashCode();
//         return HashCode.Combine(Naam);

//     }


//     public void TekenLijn(int lengte, char teken)
//     {
//         for (int teller = 0; teller < lengte; teller++)
//             Console.Write(teken);
//         Console.WriteLine();
//     }
//     public void TekenLijn(int lengte)
//     {
//         TekenLijn(lengte, '-');
//     }
//     public void TekenLijn()
//     {
//         TekenLijn(79);
//     }
//     public class WerkRegime
//     {
//         public enum RegimeType
//         {
//             Voltijds,
//             Viervijfde,
//             Halftijds
//         }
//         public WerkRegime Regime { get; set; }
//         public required RegimeType Type { get; set; }
//         public int AantalVacantiedagen
//         {
//             get
//             {
//                 switch (Type)
//                 {
//                     case RegimeType.Voltijds:
//                         return 25;
//                     case RegimeType.Viervijfde:
//                         return 20;
//                     case RegimeType.Halftijds:
//                         return 12;
//                     default: return 0;
//                 }
//             }
//         }
//         public override string ToString()
//         {
//             return Type.ToString();
//         }

//     }

// }

// public class Omzetter
// {
//     public const double CentimeterPerInch = 2.54;
//     public double CmNaarInch(double cm) => cm / CentimeterPerInch;
//     public double InchNaarCm(double inch) => inch * CentimeterPerInch;

// }

// public class Verwisselaar
// {
//     public void Verwissel(ref int getal1, ref int getal2)
//     {
//         int tussen = getal1;
//         getal1 = getal2;
//         getal2 = tussen;
//     }
// }





// public class Arbeider : Werknemer
// {
//     private decimal uurloon;
//     public decimal Uurloon
//     {
//         get => uurloon;
//         set
//         {
//             if (value >= 0m)
//                 uurloon = value;

//         }
//     }
//     private byte ploegenstelsel;
//     public byte Ploegenstelsel
//     {
//         get => ploegenstelsel;
//         set
//         {
//             if (value > 1 && value <= 3)
//                 ploegenstelsel = value;
//         }
//     }



//     public override string GetInfo()
//     {
//         return $"{base.GetInfo()}\n" +
//         $"Uurloon: {Uurloon}\n" +
//         $"Ploegenstelsel: {Ploegenstelsel}\n";
//     }
//     public override string ToString()
//     {
//         return $"{base.ToString()} {Uurloon} euro/uur";
//     }
//     public Arbeider(string naam, DateTime indienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) : base(naam, indienst, geslacht)
//     {
//         Uurloon = uurloon;
//         Ploegenstelsel = ploegenstelsel;
//     }

// }

// public class Bediende : Werknemer
// {
//     public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde) : base(naam, indienst, geslacht)
//     {
//         Wedde = wedde;
//     }
//     private decimal wedde;
//     public decimal Wedde
//     {
//         get => wedde;
//         set
//         {
//             if (value >= 0m)
//             {
//                 wedde = value;
//             }
//         }
//     }

//     public override string GetInfo()
//     {
//         return $"{base.GetInfo()}\n" +
//         $"Wedde: {Wedde}";
//     }
//     public override string ToString()
//     {
//         return $"{base.ToString()} {Wedde} euro/maand";
//     }


// }

// public class Manager : Bediende
// {
//     private decimal bonus;
//     public decimal Bonus
//     {
//         get => bonus;
//         set
//         {
//             if (value > 0m)
//             {
//                 bonus = value;
//             }
//         }

//     }
//     public Manager(string naam, DateTime indienst, Geslacht geslacht, decimal wedde, decimal bonus) : base(naam, indienst, geslacht, wedde)
//     {
//         Bonus = bonus;
//     }

//     public override string GetInfo()
//     {
//         return $"{base.GetInfo()}\n" +
//         $"Bonus: {Bonus}";
//     }

//     public override string ToString()
//     {
//         return $"{base.ToString()} Bonus: {Bonus}";
//     }

// }