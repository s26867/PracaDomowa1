namespace PracaDomowa1;

class KontenerNaPlyny : Kontener, IPowiadamiaczZagrozenia
{
    public bool CzyNiebezpieczny { get; private set; } 

    public KontenerNaPlyny(double wysokosc, double wagaWlasna, double glebokosc, double maksymalnaLadownosc, bool czyNiebezpieczny)
        : base("L", wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        CzyNiebezpieczny = czyNiebezpieczny;
    }

    public override void ZaladujLadunek(double masa)
    {
        double limit = CzyNiebezpieczny ? MaksymalnaLadownosc * 0.5 : MaksymalnaLadownosc * 0.9;
        if (masa > limit)
        {
            PowiadomOZagrozeniu(NumerSeryjny, "Próba przekroczenia bezpiecznej granicy ładunku!");
            throw new WyjatekPrzeladowania("Przekroczono limit ładowności dla kontenera na płyny.");
        }
        MasaLadunku = masa;
    }

    public override void OproznijLadunek() => MasaLadunku = 0;

    public void PowiadomOZagrozeniu(string numerSeryjny, string wiadomosc)
    {
        Console.WriteLine($"[Zagrożenie - Kontener na płyny {numerSeryjny}]: {wiadomosc}");
    }
}