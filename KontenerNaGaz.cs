namespace PracaDomowa1;

public class KontenerNaGaz : Kontener, IPowiadamiaczZagrozenia
{
    public double Cisnienie { get; private set; }

    public KontenerNaGaz(double wysokosc, double wagaWlasna, double glebokosc, double maksymalnaLadownosc, double cisnienie)
        : base("G", wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        Cisnienie = cisnienie;
    }

    public override void ZaladujLadunek(double masa)
    {
        if (masa > MaksymalnaLadownosc)
        {
            PowiadomOZagrozeniu(NumerSeryjny, "Przekroczono dopuszczalną ładowność kontenera na gaz.");
            throw new WyjatekPrzeladowania("Za dużo gazu!");
        }
        MasaLadunku = masa;
    }

    public override void OproznijLadunek()
    {
        MasaLadunku *= 0.05; // Zostaje 5%
    }

    public void PowiadomOZagrozeniu(string numerSeryjny, string wiadomosc)
    {
        Console.WriteLine($"[Zagrożenie - Kontener na gaz {numerSeryjny}]: {wiadomosc}");
    }
}