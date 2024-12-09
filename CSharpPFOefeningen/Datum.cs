using System;
using System.Globalization;



public class Datum
{
    public static void DatumOefening()
    {

        // DateTime beginTijdRekening = new DateTime();
        // DateTime beginEuro = new DateTime(2000, 1, 1);
        // DateTime mijnGeboorteDatum = new DateTime(1983, 3, 10, 19, 15, 0);
        // Console.WriteLine(beginTijdRekening);
        // Console.WriteLine(beginEuro);
        // Console.WriteLine(mijnGeboorteDatum);

        // DateTime eenDatumTijd = new DateTime(2024, 7, 1, 9, 30, 0);
        // Console.WriteLine(eenDatumTijd.ToString());
        // Console.WriteLine(eenDatumTijd.ToShortDateString());
        // Console.WriteLine(eenDatumTijd.ToLongDateString());
        // Console.WriteLine(eenDatumTijd.ToShortTimeString());
        // Console.WriteLine(eenDatumTijd.ToLongTimeString());
        // Console.WriteLine(eenDatumTijd.ToString("yyyy-MM-dd"));

        // Console.WriteLine("De datum is {0:dddd d MMMM yyyy}.", eenDatumTijd);
        // Console.WriteLine($"De datum is {eenDatumTijd:dd-MM-yyyy}.");

        // DateTime datum1 = new DateTime(2024, 1, 1);
        // DateTime datum2 = new DateTime(2024, 1, 1);
        // DateTime datum3 = new DateTime(2024, 1, 2);

        // Console.WriteLine(datum1 == datum2);
        // Console.WriteLine(datum3 > datum2);

        // DateTime factuurDatum = new DateTime(2024, 1, 1);
        // Console.WriteLine("Add 40 days: " + factuurDatum.AddDays(40));


        // DateTime factuurDatum2 = new DateTime(2024, 2, 1);
        // Console.WriteLine("Day of the year: " + factuurDatum.DayOfYear);

        // DateTime vandaag = DateTime.Today;
        // Console.WriteLine(vandaag);
        // Console.WriteLine(vandaag.DayOfWeek);
        // Console.WriteLine(vandaag.DayOfYear);
        // Console.WriteLine(vandaag.AddDays(1));


        // DateTime begindatum = new DateTime(2024, 1, 1, 8, 0, 0);
        // DateTime einddatum = new DateTime(2024, 2, 1, 12, 30, 50);
        // Console.WriteLine(begindatum);
        // Console.WriteLine(einddatum);
        // Console.WriteLine();
        // TimeSpan interval = einddatum - begindatum;
        // Console.WriteLine(interval.ToString());


        // Console.WriteLine(interval.Days);
        // Console.WriteLine(interval.TotalDays);
        // Console.WriteLine(interval.Hours);
        // Console.WriteLine(interval.TotalHours);
        // Console.WriteLine(interval.Minutes);
        // Console.WriteLine(interval.TotalMinutes);
        // Console.WriteLine(interval.Seconds);
        // Console.WriteLine(interval.TotalSeconds);
        // Console.WriteLine(interval.Microseconds);
        // Console.WriteLine(interval.TotalMilliseconds);
        // Console.WriteLine(interval.Ticks);

        // TimeOnly begintijd = new TimeOnly(8, 30, 0);
        // Console.WriteLine($"begintijd: {begintijd}");
        // Console.WriteLine($"eindtijd: {begintijd.AddHours(7.5).ToLongTimeString()}");
        // TimeOnly eindtijd = begintijd.Add(new TimeSpan(7,30,0));
        // Console.WriteLine($"eindtijd: {eindtijd.ToLongTimeString()}");


        // TimeOnly begintijd = new TimeOnly(8,30);
        // TimeOnly eindtijd = new TimeOnly(16,50);
        // TimeSpan duurtijd = eindtijd - begintijd;
        // Console.WriteLine($"duurtijd: {duurtijd.Hours} uur en "+ $"{duurtijd.Minutes} minuten");


        // TimeOnly begintijd = new TimeOnly(18, 0,0);
        // TimeOnly eindtijd = new TimeOnly(23, 59,59);
        // TimeOnly nu = new TimeOnly(19, 30, 0);
        // Console.WriteLine(nu.IsBetween(begintijd,eindtijd));
        // nu = new TimeOnly(17,30,0);
        // Console.WriteLine(nu.IsBetween(begintijd, eindtijd));

        DateTime vandaag = DateTime.Now;
        DateOnly datumVandaag = DateOnly.FromDateTime(vandaag);
        TimeOnly nu = TimeOnly.FromDateTime(vandaag);

        Console.WriteLine(vandaag);
        Console.WriteLine(datumVandaag);
        Console.WriteLine(nu);


        // Console.WriteLine("Begintijd? ");
        // TimeOnly begintijd = TimeOnly.Parse(Console.ReadLine());
        // Console.WriteLine(begintijd);
    }
}
