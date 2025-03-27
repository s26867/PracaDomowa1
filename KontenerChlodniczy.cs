namespace PracaDomowa1;

public class KontenerChlodniczy : Kontener
{
    public string RodzajProduktu { get; private set; }
    public double Temperatura { get; private set; }
    public double MinimalnaTemperatura { get; private set; }

    public KontenerChlodniczy(double wysokosc, double wagaWlasna, double glebokosc, double maksymalnaLadownosc, string rodzajProduktu, double minimalnaTemperatura, double temperatura)
        : base("C", wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        RodzajProduktu = rodzajProduktu;
        MinimalnaTemperatura = minimalnaTemperatura;
        Temperatura = temperatura;

        if (Temperatura < MinimalnaTemperatura)
            throw new Exception($"Temperatura kontenera ({Temperatura}°C) jest zbyt niska dla produktu {RodzajProduktu} (min {MinimalnaTemperatura}°C)");
    }

    public override void ZaladujLadunek(double masa)
    {
        if (masa > MaksymalnaLadownosc)
            throw new WyjatekPrzeladowania("Zbyt ciężki ładunek w kontenerze chłodniczym!");

        MasaLadunku = masa;
    }

    public override void OproznijLadunek()
    {
        MasaLadunku = 0;
    }
}