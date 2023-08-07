﻿namespace NonPrimitiveProject;

class Program
    {
        static void Main(string[] args)
        {
        //////////////////////////////////
        /// CLASSES Video
        //////////////////////////////////
        //Person jjb = new Person("Jørund");
        //Console.WriteLine($"jjb sitt navn er {jjb._name}");
        //jjb.Introduce();

        //////////////////////////////////
        /// DEMO CLASSES Video
        //////////////////////////////////

        //var jjb = new Menneske("Lori", "Wollum");
        //jjb.Introduser();

        //var casio = new Calculator("casio");
        //Console.WriteLine(casio.Gang(2, 3));

        //////////////////////////////////
        /// STRUCTS Video
        //////////////////////////////////

        // Struct er basically det samme som classes (bare litt mindre å lagre)
        // Bruksområde er hvis man har tusenvis av klasser (plass å spare da)
        // eller hvis man har noe enkelt som et punkt (med x og y verdi)
        // Hvis ikke kan du bare bruke Class

        // se egen fil Punkt.cs for syntaks (helt likt Class)
        //var firstPoint = new Punkt(3.2f, 5.1f);
        //firstPoint.Posisjon();

        //////////////////////////////////
        /// ARRAYS Video
        //////////////////////////////////

        //int[] myArray = new int[5];
        //Console.WriteLine(myArray[0]);
        //myArray[0] = 1;
        //Console.WriteLine(myArray[0]);

        //////////////////////////////////
        /// DEMO: ARRAYS Video
        //////////////////////////////////

        //var numbers = new int[3];
        //numbers[0] = 1;
        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[2]);

        //var flags = new bool[4];
        //flags[0] = true;
        //Console.WriteLine(flags[0]);
        //Console.WriteLine(flags[1]);
        //Console.WriteLine(flags[2]);
        //Console.WriteLine(flags[3]);

        //var familienMin = new string[4] { "Marlene", "Elly", "Lori", "Jørund" };
        //Console.WriteLine(familienMin[0]);
        //Console.WriteLine(familienMin[1]);
        //Console.WriteLine(familienMin[2]);
        //Console.WriteLine(familienMin[3]);

        //////////////////////////////////
        /// STRINGS Video
        //////////////////////////////////
        ///

        //Console.WriteLine("Hva er fornavnet ditt?");
        //string fornavn = Console.ReadLine();
        //Console.WriteLine("Hva er etternavnet ditt?");
        //string etternavn = Console.ReadLine();

        //// 3 måter å gjøre akkurat det samme på
        //string navn = string.Format("{0} {1}",fornavn,etternavn);
        //string navN = $"{fornavn} {etternavn}";
        //string Navn = fornavn + " " + etternavn;

        //Console.WriteLine($"Navnet er {navn}");
        //Console.WriteLine($"Navnet er {navN}");
        //Console.WriteLine($"Navnet er {Navn}");

        //var myNums = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        //var myNumsStr = string.Join("-",myNums);
        //Console.WriteLine(myNumsStr);

        //Console.WriteLine("Jeg heter \"Jørund\"");

        // Verbatim string
        string @for = "for er et reservert keyword"; // men med @ foran går det greit
        Console.WriteLine($"for: {@for}"); // men legg merke til at man må bruke her også

        string dobbelSitat = @""""""; // Ikke mulig uten @ verbatim symbolet
        Console.WriteLine($"dobbelSitat: {dobbelSitat}");

        // Hadde man ikke hatt @ under ville sekvensene
        // \T (altså tab) og \N skapt problemer
        string path = @"\\C:\Testing\New\Target";
        Console.WriteLine($"path: {@path}");

    }
}
