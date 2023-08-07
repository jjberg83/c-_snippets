namespace plusPlusProject;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b, c;
        Console.WriteLine($"a:{a}");
        Console.WriteLine($"b=a++ blir {b=a++}, a er {a}");
        Console.WriteLine($"a:{a}");
        Console.WriteLine($"c=++a blir {c = ++a}, a er {a}");
        int[] myArr = new int[5];
        //Console.WriteLine($"myArr:{myArr}");
        foreach(int tall in myArr)
        {
            Console.Write(tall);
        }
    }
}

