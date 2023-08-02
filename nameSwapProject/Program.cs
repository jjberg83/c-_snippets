namespace nameSwapProject;

class Program
{
    public static void NameShuffle(string str)
    {
        string[] ch = str.Split();
        Console.WriteLine($"Navnet er nå reversert til {ch[1]} {ch[0]}");
    }

    static void Main(string[] args)
    {
        NameShuffle("Kanon Kode");
    }
}

