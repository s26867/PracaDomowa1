namespace PracaDomowa1;

public class StatekKontenerowy
{
    public List<Kontener> Kontenery { get; private set; } = new List<Kontener>(); // Lista kontenerów.
    public double MaksymalnaPredkosc { get; private set; } // Maksymalna prędkość statku.
    public int MaksymalnaIloscKontenerow { get; private set; } // Maksymalna liczba kontenerów.
    public double MaksymalnaMasa { get; private set; } // Maksymalna masa kontenerów.

    public StatekKontenerowy(double maksymalnaPredkosc, int maksymalnaIloscKontenerow, double maksymalnaMasa)
    {
        MaksymalnaPredkosc = maksymalnaPredkosc;
        MaksymalnaIloscKontenerow = maksymalnaIloscKontenerow;
        MaksymalnaMasa = maksymalnaMasa;
    }

    public void ZaladujKontener(Kontener k)
    {
        if (Kontenery.Count >= MaksymalnaIloscKontenerow)
            throw new Exception("Nie można załadować więcej kontenerów, osiągnięto limit.");

        Kontenery.Add(k);
    }
    public void ZaladujListeKontenerow(List<Kontener> lista)
    {
        foreach (var kontener in lista)
        {
            ZaladujKontener(kontener);
        }
    }

    public void RozladujKontener(string numerSeryjny)
    {
        Kontenery.RemoveAll(k => k.NumerSeryjny == numerSeryjny);
    }
    public void ZastapKontener(string numerSeryjny, Kontener nowy)
    {
        RozladujKontener(numerSeryjny);
        ZaladujKontener(nowy);
    }
    public void PrzeniesKontenerDo(StatekKontenerowy innyStatek, string numerSeryjny)
    {
        Kontener k = Kontenery.Find(k => k.NumerSeryjny == numerSeryjny);
        if (k != null)
        {
            RozladujKontener(numerSeryjny);
            innyStatek.ZaladujKontener(k);
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Statek: Maksymalna prędkość={MaksymalnaPredkosc}, Maksymalna ilość kontenerów={MaksymalnaIloscKontenerow}, Załadowane kontenery={Kontenery.Count}");
        foreach (var k in Kontenery)
            Console.WriteLine(k);
    }
}