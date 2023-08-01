namespace nameSwapProject;

class Program
{
    public static void NameShuffle(string str)
    {
        // return $">>    {str}    >>";
        char[] ch = str.ToCharArray();
        Console.WriteLine($"Arrayen er nå {ch}");
    }

    static void Main(string[] args)
    {
        NameShuffle("KanonKode");
    }
}

