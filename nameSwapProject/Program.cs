namespace nameSwapProject;

class Program
{
    public static string NameShuffle(string str)
    {
        return $">>    {str}    >>";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(NameShuffle("KanonKode"));
    }
}

