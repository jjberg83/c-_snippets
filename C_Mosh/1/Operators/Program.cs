namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = a++;
        Console.WriteLine($"a: {a}, b: {b}");

        int c = 1;
        int d = ++c;
        Console.WriteLine($"c: {c}, d: {d}");

        bool sant = true;
        bool vel = true;
        bool eller = false;

        //AND og OR er doble
        Console.WriteLine($"{sant && vel}");
        Console.WriteLine($"{sant && eller}");
        Console.WriteLine($"{sant || eller}");

        //bitwise operators er enkle
        byte nummerEn = 1;
        byte nummerTo = 2;
        byte nummerTre = 3;
        Console.WriteLine($"{nummerEn & nummerTre}");
        Console.WriteLine($"{nummerEn | nummerTre}");

    }
}

