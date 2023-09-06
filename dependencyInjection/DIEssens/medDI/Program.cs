// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
                      .AddSingleton<IKoneKommunikasjon, SkrikTilKone>()
                      .AddSingleton<Mann>()
                      .BuildServiceProvider();

var jjberg = serviceProvider.GetRequiredService<Mann>();


jjberg.SiNoe();
Console.WriteLine();


class SkrikTilKone : IKoneKommunikasjon
{
    public void Respons()
    {
        Console.WriteLine("Faen altså, ta oppvasken");
    }
}

class KosePratTilKone : IKoneKommunikasjon
{
    public void Respons()
    {
        Console.WriteLine("Du ser så flott ut i dag");
    }
}

public interface IKoneKommunikasjon
{
    void Respons();
}

class Mann
{
    private readonly IKoneKommunikasjon _koneKommunikasjon;

    public Mann(IKoneKommunikasjon koneKommunikasjon) // konstruktør krever at instans må injectes
    {
        _koneKommunikasjon = koneKommunikasjon;
    }

    public void SiNoe()
    {
        _koneKommunikasjon.Respons();
    }
}

