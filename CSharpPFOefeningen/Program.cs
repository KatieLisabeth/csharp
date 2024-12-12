//using System;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CSharpPFCursus;

public class Program
{
    static void Main(string[] args)
    {
        //Variables.VariableOefening();
        //Datum.DatumOefening();
        //Selecties.SelectieOefening();
        // Functies.FunctiesOefeningen();
        // Arrays.ArraysOefening();
        // Werknemer ik;
        // ik = new Werknemer();
        //Console.WriteLine(ik is null ? "Niet verbonden" : "Verbonden");
        // if (ik is null)
        // {
        //     Console.WriteLine("Niet verbonden");
        // }
        // else
        // {
        //     Console.WriteLine("Verbonden");
        // }
        //ik = null!;
        //Console.WriteLine(ik is null ? "Niet verbonden" : "Verbonden");
        // if (ik is null)
        // {
        //     Console.WriteLine("Niet verbonden");
        // }
        // else
        // {
        //     Console.WriteLine("Verbonden");
        // }
        // ik.Naam = "Asterix";
        // ik.Geslacht = Geslacht.Man;
        // ik.InDienst = new DateTime(2024, 1, 1);
        // Console.WriteLine(ik.Naam);
        // Console.WriteLine(ik.Geslacht);
        // Console.WriteLine(ik.InDienst);
        // ik.Naam = "Asterix";
        // ik.Geslacht = Geslacht.Man;
        // ik.InDienst = new DateTime(2020, 1, 1);
        // Console.WriteLine(ik.VerjaarAncien);
        // Console.WriteLine(ik.Naam);
        // Werknemer mezelf;
        // mezelf = ik;
        // Console.WriteLine("mezelf: " + mezelf.Naam);
        // Console.WriteLine(ik == mezelf);
        // ik = null!;

        // Console.WriteLine(ik == mezelf);
        // Console.WriteLine("mezelf after ik is null: " + mezelf.Naam);

        // Werknemer asterix = new Werknemer();
        // asterix.AantalKinderen = null;

        //Console.WriteLine(asterix);

        // int? aantalKinderen = null;
        // int aantalKamers = aantalKinderen ?? 0;
        // //int aantalKamers = aantalKinderen.HasValue ? aantalKinderen.Value : 0;
        //Console.WriteLine($"Er zijn {aantalKamers} kinderkamers nodig");
        // //Console.WriteLine(aantalKinderen.HasValue ? $"Er zijn {aantalKinderen} kinderen" : "Het aantal kinderen is onbekend");
        // // aantalKinderen = 7;

        //System.Console.WriteLine($"Er zijn {aantalKinderen.Value} kinderen");
        // ik.Naam = "Asterix";
        // ik.Geslacht = Geslacht.Man;
        // ik.InDienst = new DateTime(2024, 1, 1);

        // Werknemer jij = new Werknemer();
        // jij.Naam = "Obelix";
        // jij.Geslacht = Geslacht.Man;
        // jij.InDienst = new DateTime(2024, 1, 2);
        LijnenTrekker lijnenTrekker = new LijnenTrekker();
        // Console.WriteLine(ik.GetInfo());
        // lijnenTrekker.TekenLijn(30, '-');
        // Console.WriteLine(jij.GetInfo());
        // lijnenTrekker.TekenLijn(79, '=');
        // lijnenTrekker.TekenLijn();
        // lijnenTrekker.TekenLijn(10);
        // lijnenTrekker.TekenLijn(teken: '*', lengte: 10);

        // Omzetter omzetter = new Omzetter();
        // Console.WriteLine("Afstand in cm: ");
        // double cm = double.Parse(Console.ReadLine()!);
        // Console.WriteLine($"{omzetter.InchNaarCm(cm)} inches");
        // lijnenTrekker.TekenLijn();
        // Console.WriteLine("Afstand in inches: ");
        // double inches = double.Parse(Console.ReadLine()!);
        // Console.WriteLine($"{omzetter.CmNaarInch(inches)} inches");
        // Werknemer[] onzeWerknemers = new Werknemer[5];
        // for (int teller = 0; teller < onzeWerknemers.Length; teller++)
        // {
        //    var worker = onzeWerknemers[teller] = new Werknemer();
        //    Console.WriteLine(worker);
        // }
        // int eerste = 10, tweede = 20;
        // Verwisselaar verwisselaar = new Verwisselaar();
        // verwisselaar.Verwissel(ref eerste, ref tweede);
        // Console.WriteLine("eerste was 10 nu =>: " + eerste);
        // Console.WriteLine("tweede was 20 nu =>: " + tweede);

        // Werknemer ik = new Werknemer();
        // Console.WriteLine(ik.GetInfo());
        // Console.WriteLine(ik.Naam.ToUpper());

        // Werknemer werknemer = new Werknemer("Asterix", new DateTime(2024, 1, 1), Geslacht.Man);
        // Console.WriteLine(werknemer.GetInfo());

        // Werknemer jij = new()
        // {
        //     Naam = "Obelix",
        //     InDienst = new DateTime(2024, 1, 26),
        //     Geslacht = Geslacht.Man,



        // };
        // Console.WriteLine("Jij: " + jij.GetInfo()); //personeelsfeest 1,1,0001 date not set

        // Werknemer2 werknemer2 = new Werknemer2("", new DateTime(2020, 12, 12), Geslacht.Man);
        // Console.WriteLine(werknemer2.GetInfo());

        // Werknemer isa = new()
        // {
        //     Naam = "Isa",
        //     InDienst = new DateTime(2018, 1, 26),
        //     Geslacht = Geslacht.Vrow
        // };
        // Werknemer.Personeelsfeest = new DateOnly(2024, 12, 12);
        // Console.WriteLine(Werknemer.Personeelsfeest);
        // //ik.Naam = "Isabella";
        // Console.WriteLine(isa.GetInfo());
        // Console.WriteLine(jij.GetInfo());


        // Arbeider arbeider = new("Asterix", new DateTime(2024, 1, 1), Geslacht.Man, 24.79m, 3);
        // Console.WriteLine(arbeider.GetInfo());

        // Console.WriteLine("Bediende");
        // Bediende bediende = new("Asterix", new DateTime(2024, 1, 1), Geslacht.Man, 2400.79m);
        // Console.WriteLine(bediende.GetInfo());


        // Manager manager = new Manager("Katie", new DateTime(2024, 1, 1), Geslacht.Vrow, 24.79m, 7000m);
        // Manager mezelf = manager;
        // Manager dezelfde = new Manager("Katie", new DateTime(2024, 1, 1), Geslacht.Vrow, 24.79m, 7000m);
        // //Before implemented equals function in manager class
        // // Console.WriteLine(manager.Equals(mezelf)); //True
        // // Console.WriteLine(manager.Equals(dezelfde)); //False
        // //After implemented equals function in manager class
        // Console.WriteLine(manager.Equals(mezelf)); //True
        // Console.WriteLine(manager.Equals(dezelfde)); //True
        //                                              // Console.WriteLine(manager.GetInfo());
        //                                              // Console.WriteLine(manager is Manager);
        //                                              // Console.WriteLine(manager is Bediende);
        //                                              // Console.WriteLine(manager is Werknemer);
        //                                              // Console.WriteLine(manager.ToString());
        //                                              // Console.WriteLine(manager is string);
        //                                              // Console.WriteLine(manager is Manager);

        // // Console.WriteLine(manager.ToString());
        // object obj = new Werknemer("Asterix", DateTime.Today, Geslacht.Man);
        // Werknemer deAndere = (Werknemer)obj;
        // Console.WriteLine(deAndere);

        // Werknemer one = new Bediende("One", DateTime.Today, Geslacht.Man, 1500m);
        // Werknemer two = new Arbeider("Two", DateTime.Today, Geslacht.Man, 10m, 1);
        // Bediende? hij;

        // hij = (Bediende)one;
        // Console.WriteLine(hij.GetInfo());

        // hij = one as Bediende;
        // if (hij != null)
        //     Console.WriteLine(hij.GetInfo());

        // hij = two as Bediende;
        // if (hij != null)
        //     Console.WriteLine(hij.GetInfo());

        ///abstract classes
        ///
        Arbeider asterix = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);
        Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 24.79m);
        Manager idefix = new Manager("Idefix", new DateTime(1995, 1, 1), Geslacht.Man, 24.79m, 7000m);
        Console.WriteLine(asterix.Premie);
        Console.WriteLine(obelix.Premie);
        Console.WriteLine(idefix.Premie);

        Console.WriteLine("Windows" + 1+ 1 );

    }




}

