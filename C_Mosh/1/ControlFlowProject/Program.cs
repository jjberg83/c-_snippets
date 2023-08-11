namespace ControlFlowProject;

class Program
{
    static void Main(string[] args)
    {
        /////////////////////////////
        /// DEMO IF/ELSE, SWITCH
        /////////////////////////////

        //var hour = 10;

        //// Har man kun EN linje under if, else if og else
        //// trenger man ikke curly braces
        //if (hour > 0 && hour < 12) 
        //    Console.WriteLine("Det er morgen.");
        //else if (hour >= 12 && hour < 18)
        //    Console.WriteLine("Det er ettermiddag.");
        //else
        //    Console.WriteLine("Det er kveld.");

        //bool isGoldMember = true;
        //float price;
        //if (isGoldMember)
        //    price = 19.95f;
        //else
        //    price = 29.95f;

        // med conditional operator
        //price = isGoldMember ? 19.96f : 29.96f;

        //Console.WriteLine($"Prisen er {price}");

        //var sesong = Season.Summer;

        //Console.WriteLine(sesong);
        //Console.WriteLine((int)sesong);

        //switch (sesong)
        //{
        //    case Season.Spring:
        //        Console.WriteLine("Det er vår i luften!");
        //        break;
        //    case Season.Summer:
        //        Console.WriteLine("Sommer og sol!");
        //        break;
        //    case Season.Autumn:
        //        Console.WriteLine("Høsten kommer, takk for sommer!");
        //        break;
        //    case Season.Winter:
        //        Console.WriteLine("Det snør, det snør...");
        //        break;

        //}

        /////////////////////////////
        /// DEMO FOR LOOPS
        /////////////////////////////

        //for (var i = 1; i <= 10; i++)
        //{
        //    if (i%2==0)
        //        Console.WriteLine(i);
        //}
        //for (var i = 10; i > 0; i--)
        //{
        //    if (i%2==0)
        //        Console.WriteLine(i);
        //}

        /////////////////////////////
        /// DEMO FOREACH LOOPS
        /////////////////////////////
        ///

        //var name = "Jørund";

        // med for loop
        //for (var i = 0; i < name.Length; i++)
        //{
        //    Console.WriteLine(name[i]);
        //}

        // Samme med foreach
        //foreach (char bokstav in name)
        //{
        //    Console.WriteLine(bokstav);
        //}

        //iterer over en array
        //var minArray = new int[4] { 10, 20, 30, 40};
        //foreach(var tall in minArray)
        //{
        //    Console.WriteLine(tall);
        //}

        ///////////////////////////
        /// DEMO WHILE LOOPS
        ///////////////////////////
        ///

        // Display even numbers up to 10
        //var i=1;
        //while (i <= 10)
        //{
        //    if (i%2 == 0)
        //        Console.WriteLine(i);
        //    i++;
        //}

        //while (true)
        //{
        //    Console.WriteLine("What´s your name?");
        //    var name = Console.ReadLine();
        //    if (String.IsNullOrWhiteSpace(name))
        //    {
        //        Console.WriteLine("You didn´t write anything, so loop will stop"); ;
        //        break;
        //    }
        //    Console.WriteLine($"You wrote: {name}");
        //}
        //Console.WriteLine("While loop ferdig");
    }
}

