namespace OperatorsDemo;

class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        var b = 3;
        Console.WriteLine($"a / b = {a/b}");
        Console.WriteLine($"a / b = {(float)a / (float)b}");

        var c = 1;
        var d = 2;
        var e = 3;
        Console.WriteLine(!(c != d));
        Console.WriteLine(!(e > c || e == d));
    }
}

