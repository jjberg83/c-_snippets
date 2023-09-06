// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.DependencyInjection;


var enMann = new Mann();
enMann.SiNoe();



class SkrikTilKone
{
    public void Respons()
    {
        Console.WriteLine("Faen altså, ta oppvasken");
    }
}

class KosePratTilKone
{
    public void Respons()
    {
        Console.WriteLine("Du ser så flott ut i dag");
    }
}

class Mann
{
    KosePratTilKone kommunikasjon =  new KosePratTilKone();
    // SkrikTilKone kommunikasjon = new SkrikTilKone();


    public void SiNoe()
    {
        kommunikasjon.Respons();
    }
}

