using System;
using System.Security.Cryptography.X509Certificates;

public enum Seizoen
{
    Lente, Zomer, Herfst, Winter
}
public class Arrays
{
    public static void ArraysOefening()
    {
        //int AantalMaanden = 12;
        // double[] temperaturen = new double[AantalMaanden];
        // for (int maand = 1; maand <= AantalMaanden; maand++)
        // {
        //    Console.WriteLine("Geef de temperatuur voor maand {0} ", maand);
        //     temperaturen[maand - 1] = double.Parse(Console.ReadLine()!);
        // }

        // Console.WriteLine("Je typte volgende temperaturen: ");
        // for (maand = 1, maand <= AantalMaanden; maand++)
        //     Console.WriteLine($"Maand {maand}: {temperaturen[maand - 1]}");

        // int[] dagenPerMaand={31,28,31,30,31,30,31,31,30,31,30,31};
        // for(int maand = 0; maand < dagenPerMaand.Length; maand++){
        //     Console.WriteLine(dagenPerMaand[maand]);
        // }

        int huidigJaar = DateTime.Today.Year;
        Console.WriteLine(huidigJaar);
        for (int maand = 1; maand <= 12; maand++)
        {
            Console.WriteLine(DateTime.DaysInMonth(huidigJaar, maand));
        }
        var getallen = new[] { 10, 20, 30 };
        Console.WriteLine(getallen.GetType());
        //Int32[]
        string[] stripHelden = ["Asterix", "Obelix", "Idefix"];
        foreach (string stripHeld in stripHelden)
        {
            Console.WriteLine(stripHeld);
        }

        string[] maanden = ["januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "november", "december"];
        foreach (string maand in maanden)
        {
            Console.WriteLine(maand.ToUpper());
        }

        // Console.WriteLine("Aantal bankrekeningen: ");
        // int aantalRekeningen = int.Parse(Console.ReadLine()!);
        // ulong[] rekeningNrs = new ulong[aantalRekeningen];
        // for (int teller = 1; teller <= aantalRekeningen; teller++)
        // {
        //     Console.WriteLine("Nummer van {0} rekening: ", teller);
        //     rekeningNrs[teller - 1] = ulong.Parse(Console.ReadLine()!);
        // }
        // Console.WriteLine("Dit zijn de nummers van je rekeningen");
        // foreach (ulong rekeningNr in rekeningNrs)
        // {
        //     Console.WriteLine(rekeningNr);
        // }


        // string[] stripHelden2 = ["Asterix", "Obelix", "Idefix", "Panoramix"];
        // Console.WriteLine(stripHelden2[2]);
        // Console.WriteLine(stripHelden2[0]);

        string[] stripHeld3 = { "Asterix", "Obelix", "Idefix", "Panoramix" };
        string[] deelArray;

        deelArray = stripHeld3[1..3];
        Console.WriteLine(string.Join(' ', deelArray));

        deelArray = stripHeld3[0..];
        Console.WriteLine(string.Join(' ', deelArray));

        deelArray = stripHeld3[..2];
        Console.WriteLine(string.Join(' ', deelArray));

        deelArray = stripHeld3[..^1];
        Console.WriteLine(string.Join(' ', deelArray));

        Range range = new Range(1, 4);// from 1 including 1 until 4 included 3
        deelArray = stripHeld3[range];
        Console.WriteLine(string.Join(' ', deelArray));

        string[,] landenHoofdstedenTalen = { { "Cuba", "Havana", "Spaans" }, { "Brazilië", "Brasilia", "Portugees" } };
        Console.WriteLine(landenHoofdstedenTalen[1, 1]);

        string[] namen = ["Asterix", "Obelix", "Idefix", "Panoramix"];
        Console.WriteLine("Beginsituatie: ");
        foreach (string naam in namen)
        {
            Console.WriteLine(naam);
            Array.Sort(namen);
            Console.WriteLine("Na Sort: ");
        }
        foreach (string naam in namen)
        {
            Console.WriteLine(naam);
            Array.Reverse(namen);
            Console.WriteLine("Na Reverse: ");
        }
        foreach (string naam in namen)
        {
            Console.WriteLine(naam);
            string[] kopie = new string[namen.Length];
            Array.Copy(namen, kopie, namen.Length);
            Console.WriteLine("Kopie: ");

        }
        foreach (string naam in namen)
        {
            Console.WriteLine(naam);

            Console.WriteLine("Eerste Idefix: " + Array.IndexOf(namen, "Idefix"));

        }
        Seizoen plukseizoen = Seizoen.Herfst;
        Console.WriteLine(plukseizoen);
        Console.WriteLine((int)plukseizoen);


    }

}