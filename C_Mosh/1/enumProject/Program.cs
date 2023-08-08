namespace enumProject;

class Program
{
    static void Main(string[] args)
    {
        // Enums brukes når man har flere relaterte konstanter
        // I stedet for dette

        //const int RegularAirMail = 1;
        //const int RegisteredAirMail = 2;
        //const int Express = 3;

        //Console.WriteLine(RegularAirMail);
        //Console.WriteLine(RegisteredAirMail);
        //Console.WriteLine(Express);
        var method = ShippingMethod.RegularAirMail;
        Console.WriteLine($"method: {method}");
    }
}

