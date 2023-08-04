namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {

        // Får ikke lov til dette fordi data KAN tapes
        // (i dette tilfelle gjør det ikke det fordi
        // kun de tre førte tomme bytesene slettes
        // 00000000 00000000 00000000 00000001
        // int dinInt = 1;
        // byte dinByte = dinInt;

        // Her sier vi at vi vet at data loss kan skje
        // siden en INT tar 4 bytes
        // Imidlertid bruker vi kun 1 byte, så selv
        // om 3 strykes, er det ingen info her.
        // Derfor overstyrer vi og sier at det er trygt.
        int minInt = 1;
        byte minByte = (byte)minInt;

        string strTall = "1";
        int intTall = Convert.ToInt32(strTall);
        int intTallParse = int.Parse(strTall);
        Console.WriteLine($"intTall: {intTall}, intTallParse: {intTallParse}");

        // 257 blir 1 00000001 i binær
        int dataLoss = 257;
        byte dataLossByte = (byte)dataLoss;
        Console.WriteLine($"dataLossByte: {dataLossByte}");
        // Vi ser at her har vi hatt dataloss.
        // Tallet skulle vært 257, nå er det 1.

        string strTall2 = "1234";
        int tall2 = Convert.ToInt32(strTall2);
        Console.WriteLine($"tall2: {tall2}");

        string strTall3 = "4321";
        try
        {
            byte tall3 = Convert.ToByte(strTall3);
            Console.WriteLine($"tall3: {tall3}");
        }
        catch
        {
            Console.WriteLine("Why you problem me?");
        }

        try
        {
            string sant = "true";
            bool vel = Convert.ToBoolean(sant);
            Console.WriteLine($"vel: {vel}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Pokker, kunne ikke konvertere til Boolean");
        }
    }
}

