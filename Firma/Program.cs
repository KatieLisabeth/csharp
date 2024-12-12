using System;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;
using MaterialStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;


public class Program
{
    static void Main(string[] args)
    {
        Object[] dingen = new Object[4];
        dingen[0] = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);
        dingen[1] = new Fotokopiemachine("Racekyo", 500, 0.025m);
        //dingen[2] = null;
        dingen[3] = "C#";

        static void ToonGegevens(Object? obj)
        {
            if (obj is Werknemer w)
            {
                //Werknemer w = (Werknemer)obj;
                Console.WriteLine($"Werknemer {w.Naam} kost {w.BerekenKostprijs()} euro");
            }
            else if (obj is Fotokopiemachine f)
            {
                //Fotokopiemachine f = (Fotokopiemachine)obj;
                Console.WriteLine($"Fotokopiemachine {f.SerieNr} kopieerde {f.AantalGekopieeerdeBlz} en kost {f.BerekenKostprijs()} euro");
            }
            else if (obj is null)
            {
                Console.WriteLine("Parameter = null");
            }
            else
            {
                Console.WriteLine("Onbekende type");
            }
        }

        foreach (Object item in dingen)
        {
            ToonGegevens(item is IKost);
            // Console.WriteLine($"ding is IKost: {something}");
        }

        Object?[] lijst = new Object?[5];
        lijst[0] = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);
        lijst[1] = new Bediende("Obelix", new DateTime(2024, 1, 1), Geslacht.Man, 1000m);
        lijst[2] = new Bediende("Walhalla", new DateTime(2024, 1, 1), Geslacht.Vrow, 2000m);
        lijst[3] = null;
        lijst[4] = "C3!0";

        foreach (var item in lijst)
        {
            switch (item)
            {
                case Werknemer w when w.Geslacht == Geslacht.Man:
                    Console.WriteLine($"{w.Naam} is een mannelijke werknemer");
                    break;
                case Arbeider a when a.Geslacht == Geslacht.Vrow:
                    Console.WriteLine($"{a.Naam} is een vrouwelijke werknemer" +
                    $"met een uurloon van {a.Uurloon} euro");
                    break;
                case Arbeider a when a.Geslacht == Geslacht.Man:
                    Console.WriteLine($"{a.Naam} is een mannelijke werknemer" +
                    $"met een uurloon van {a.Uurloon} euro");
                    break;
                case Bediende b when b.Geslacht == Geslacht.Vrow:
                    Console.WriteLine($"{b.Naam} is een vrouwelijke werknemer" +
                    $"met een wedde {b.Wedde} euro");
                    break;
                case Bediende b when b.Geslacht == Geslacht.Man:
                    Console.WriteLine($"{b.Naam} is een mannelijke werknemer" +
                    $"met een wedde {b.Wedde} euro");
                    break;
                case null:
                    Console.WriteLine($"null");
                    break;
                default:
                    Console.WriteLine($"{item} is geen werknemer");
                    break;
            }
        }

        // Firma.Materiaal.Status statusBoorMachine = Firma.Materiaal.Status.Werkend;
        // Firma.Personeel.Status statusChef = Firma.Personeel.Status.HogerKader;
        // Console.WriteLine(statusBoorMachine);
        // Console.WriteLine(statusChef);

         MaterialStatus statusBoorMachine = MaterialStatus.Werkend;
         PersoneelStatus statusChef = PersoneelStatus.HogerKader;

         Console.WriteLine(statusBoorMachine);
         Console.WriteLine(statusChef);


    }
}
