using System;
using System.Runtime.Intrinsics.Arm;

public class Functies
{
    public static void FunctiesOefeningen()
    {

        Console.WriteLine("Asterix");

        for (int teller = 0; teller < 20; teller++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
        Console.WriteLine("Obelix");
        for (int teller = 0; teller < 20; teller++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
        Console.WriteLine("Einde Programma");
        for (int teller = 0; teller < 20; teller++)
        {
            Console.Write('-');
        }
        Console.WriteLine();

        // float LeesPunten()
        // {
        //     Console.WriteLine("Geef een cijfer tussen 0 en 10");
        //     float punten = float.Parse(Console.ReadLine()!);
        //     while (punten < 0f || punten > 10f)
        //     {
        //         Console.WriteLine("Foutief cijfer! Geef een cijfer tussen 0 en 10");
        //         punten = float.Parse(Console.ReadLine()!);
        //     }
        //     return punten;
        // }

        Console.WriteLine("Punten Wiskunde? ");
        // float puntenWiskunde = LeesPunten();
        // Console.WriteLine(puntenWiskunde);

        //     void TekenLijn(int lenghte){
        //         for(int teller=0; teller < lenghte; teller++){
        //             Console.Write('-');
        //             Console.WriteLine();
        //         }
        //     }

        //   TekenLijn(7);

        // void TekenLijn(int lenghte, char tenen = '-')
        // {
        //     for (int teller = 0; teller < lenghte; teller++)
        //     {
        //         Console.Write(tenen);
        //     }
        //     Console.WriteLine();
        // }

        //TekenLijn(7);
        //TekenLijn(lenghte:20);
        TekenLijn(lenghte: 20, tenen: '=');


        // double CmNaarInch(double cm)
        // {
        //     return cm / 2.54;
        // }

        // Console.WriteLine("Afstand in cm: ");
        // double cm = double.Parse(Console.ReadLine()!);
        // Console.WriteLine($"{cm} cm = {CmNaarInch(cm)} inches");


        void VerwisselNaarAndereVariabelen(int getal1, int getal2, out int verwisseld1, out int verwisseld2)
        {
            verwisseld1 = getal1;
            verwisseld2 = getal2;
        }

        int eerste = 10, tweede = 20;

        VerwisselNaarAndereVariabelen(eerste, tweede, out int resultaat1, out int resultaat2);

        Console.WriteLine(resultaat1);
        Console.WriteLine(resultaat2);

        Console.WriteLine("Afstand in cm: ");
        // if (double.TryParse(Console.ReadLine(), out double cm))
        // {
        //     Console.WriteLine($"{CmNaarInch(cm)} inches");
        // }
        // else
        // {
        //     Console.WriteLine("Geen correct getal");
        // }


        const double CentimeterPerInch = 2.54;
        Console.WriteLine("Afstand in cm: ");
        double cm = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"{cm} cm = {CmNaarInch(cm)} inches");

        double CmNaarInch(double cm){
            return cm /CentimeterPerInch;
        }
        double InchNaarCm(double inch){
            return inch * CentimeterPerInch;
        }
        void TekenLijn(int lenghte, char tenen = '-')
        {
            for (int teller = 0; teller < lenghte; teller++)
            {
                Console.Write(tenen);
            }
            Console.WriteLine();
        }


    }
}