using System;

public class Variables
{
    public static void VariableOefening()
    {
        // string naam;
        // naam = "Asterix";
        // string groteKrijger;
        // groteKrijger = naam;
        //Console.WriteLine(groteKrijger);

        // string krijger1= "Asterix";
        // string krijger2 = "Obelix";
        // string samen = krijger1 + " en "+ krijger2;
        // Console.WriteLine(samen);

        // int seizoenen = 4;
        // string eindeZin = " seizoenen";
        // string samen = seizoenen + eindeZin;
        // Console.WriteLine(samen);




        // string bericht = "hallo";
        // string samen = bericht + " iedereen";
        // Console.WriteLine(samen);


        // System.Text.StringBuilder bericht = new System.Text.StringBuilder("hallo");
        // Console.WriteLine(bericht);
        // bericht.Append(" iedereen");
        // Console.WriteLine(bericht);

        // string krijger1 = "Asterix";
        // string krijger2 = "Obelix";
        // string groteKrijger = "Asterix";
        // string kleineKrijger = "asterix";
        // Console.WriteLine(krijger1 == krijger2);
        // Console.WriteLine(krijger1 == groteKrijger);
        // Console.WriteLine(krijger1 == kleineKrijger);
        // Console.WriteLine(krijger1.CompareTo(krijger2));

        // string naam = "Asterix en Obelix";
        // Console.WriteLine(naam.ToUpper());
        // Console.WriteLine(naam.ToLower());
        // Console.WriteLine(naam.Substring(2));

        // Console.WriteLine(naam.Substring(2, 5));
        // Console.WriteLine(naam.Insert(0, "De vrienden"));
        // Console.WriteLine(naam.Remove(8, 3));
        // Console.WriteLine(naam.Replace("x", "s"));


        // char eersteLetter = krijger1[0];
        // char laatsteLetter = krijger1[krijger1.Length - 1];
        // Console.WriteLine(eersteLetter);
        // Console.WriteLine(laatsteLetter);


        // int kinderen =7 ;
        // string kinderenWoord = kinderen.ToString();
        // Console.WriteLine(kinderenWoord);


        // const float CmInch = 2.54f;
        // Console.Write("Geef een lengte in cm: ");
        // float cm = float.Parse(Console.ReadLine());
        // Console.WriteLine("lengte in inch: " + cm/ CmInch);


        // Console.WriteLine(@"De standaard windows directory is c:\windows");
        // Console.WriteLine(@"Dit is een dubbel aanhalingsteken:"".");
        // char aanhalingsteken = '\'';
        // System.Console.WriteLine(aanhalingsteken);

        double straal = 5.0;
        Console.WriteLine($"De omtrek van een cirkel me straal {straal} cm" + $"bedraagt {2 * Math.PI * straal}cm");

        Console.WriteLine($"De omtrek van een cirkel me straal {straal} cm" + $"bedraagt {2 * Math.PI * straal:0.00}cm");

        var jsonString = """
           {
              "voornam": "Jan",
              "nam": "Jansens"
           }
        """;

        var jsonString2 = @"
           {
              ""voornam"": ""Jan"",
              ""nam"": ""Jansens""
            }
        ";
        Console.WriteLine(jsonString);
        Console.WriteLine(jsonString2);

        var voornam = "Piet";
        var naam = "Pieters";
        var json = $$"""
           {
              "voornam": "{{voornam}}",
              "nam": "{{naam}}",
            }
        """;

        Console.WriteLine(json);
    }
}