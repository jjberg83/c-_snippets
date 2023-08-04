namespace NonPrimitiveProject;

public class Menneske
{
    public string forNavn;
    public string etterNavn;

    public Menneske(string fNavn, string eNavn)
    {
        forNavn = fNavn;
        etterNavn = eNavn;
    }
    public void Introduser()
    {
        Console.WriteLine($"Hei, {forNavn} {etterNavn} her!");
    }
}

