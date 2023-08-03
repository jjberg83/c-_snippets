namespace OverflowProject;

class Program
{
    static void Main(string[] args)
    {
        // Checked gjør at mittNummer ikke starter om igjen på 0
        // Mosh bruker det ikke, han bare endrer typen til
        // datatype som er litt større
        checked
        {
            try
            {
                byte mittNummer = 255;
                mittNummer += 1;
                Console.WriteLine(mittNummer);
            }
            catch
            {
                Console.WriteLine("Noe gikk galt her...");
                Console.WriteLine("Testing av cw");
                Console.WriteLine("Enda litt øving av cw");
                Console.WriteLine("Finnes det en enda kortere måte?");
                Console.WriteLine("Nei, men dette er jo raskt nok!");
            }
        }
    }
}

