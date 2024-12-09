// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Console.Write("Asterix");
// Console.Write(" en Obelix");
// Console.WriteLine("Asterix");
// Console.WriteLine("Obelix");
// Console.WriteLine("Hel" + "lo");
// Console.WriteLine("uint max value: " + uint.MaxValue);
// byte statenUSA;
// ushort belgischeBieren;
// uint afstandNaarMaan;
// ulong aantalMensen;
// //float alcoholDuvel;
// char geslacht;
// bool gehuwd;

// statenUSA = 50;
// belgischeBieren = 1400;
// afstandNaarMaan = 382170;
// aantalMensen = 6122567014ul;
// //alcoholDuvel=8.5f;
// geslacht = 'M';
// gehuwd = true;

// Console.WriteLine(statenUSA);
// Console.WriteLine(belgischeBieren);
// Console.WriteLine(afstandNaarMaan);
// Console.WriteLine(aantalMensen);
// //Console.WriteLine(alcoholDuvel);
// Console.WriteLine(geslacht);
// Console.WriteLine(gehuwd);

// float alcoholDuvel, alcoholHapkin;
// alcoholDuvel = alcoholHapkin = 8.5f;
// Console.WriteLine(alcoholDuvel);
// Console.WriteLine(alcoholHapkin);
// // using System;
// // namespace CSharpPFCursus{
// // class Program{
// //     static void Main(string[] arg){
// //         Console.WriteLine("Hello, World!");
// //     }
// // }
// // }
// decimal weddeInBEF = 80000m;
// decimal weddeInEuro = weddeInBEF / 40.3399m;
// Console.WriteLine(weddeInEuro);


// // int eenWedde = 1500;
// // double eenTweedeWedde = eenWedde;


// // double eenWedde = 1500.78;
// // int eenTweedeWedde = (int)eenWedde;
// // Console.WriteLine(eenWedde);
// // Console.WriteLine(eenTweedeWedde);

// int getal1 = 1500;
// byte getal2 = (byte)getal1;
// Console.WriteLine("getal1: " + getal1);
// Console.WriteLine("getal2: " + getal2);

// double eenWedde = 1500.78;
// Console.WriteLine((int)eenWedde);

// Console.WriteLine((int)'A');

// Console.WriteLine((char)65);


// var aantalKinderen = 3;
// var wedde = 1500m;
// Console.WriteLine(aantalKinderen.GetType());
// Console.WriteLine(wedde.GetType());


// const decimal EuroKoers = 40.3399m;
// Console.WriteLine(EuroKoers);

// const float CmInch = 2.54f;
// float cm = 100.0f;
// float inch = cm / CmInch;
// Console.WriteLine("cm: " + cm);
// Console.WriteLine("inch: " + inch);

public class Program {
    static readonly double GuldenSnede = (Math.Sqrt(5.0)+1.0)/2.0;
    private static void Main(string[] arg){
        Console.WriteLine("GuldenSnede: "+ GuldenSnede);
    }
}