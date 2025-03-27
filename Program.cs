namespace PracaDomowa1
{

    class Program
    {
        static void Main(string[] args)
        {
           // Tworzenie statków
        var statek1 = new StatekKontenerowy(25, 5, 50000);
        var statek2 = new StatekKontenerowy(20, 3, 30000);

        // Tworzenie kontenerów różnych typów
        var kontenerPlyny = new KontenerNaPlyny(240, 1000, 300, 10000, true);
        var kontenerGaz = new KontenerNaGaz(240, 1200, 300, 8000, 2.5);
        var kontenerChlodniczy = new KontenerChlodniczy(250, 900, 300, 12000, "Banany", 2, 4);

        // Ładowanie ładunku
        kontenerPlyny.ZaladujLadunek(4500); 
        kontenerGaz.ZaladujLadunek(7000); 
        kontenerChlodniczy.ZaladujLadunek(10000); 

        // Dodanie kontenerów do statku 1
        statek1.ZaladujKontener(kontenerPlyny);
        statek1.ZaladujKontener(kontenerGaz);
        statek1.ZaladujKontener(kontenerChlodniczy);

        // Wyświetlenie danych statku 1
        Console.WriteLine("=== Informacje o statku 1 ===");
        statek1.WyswietlInformacje();

        // Tworzenie nowego kontenera chłodniczego i zastąpienie starego
        var nowyChlodniczy = new KontenerChlodniczy(250, 950, 300, 12000, "Banany", 2, 5);
        nowyChlodniczy.ZaladujLadunek(9000);
        statek1.ZastapKontener(kontenerChlodniczy.NumerSeryjny, nowyChlodniczy);

        // Przenoszenie kontenera na drugi statek
        statek1.PrzeniesKontenerDo(statek2, kontenerGaz.NumerSeryjny);

        // Wyświetlenie danych obu statków po operacjach
        Console.WriteLine("\n=== Po operacjach ===");
        Console.WriteLine("--- Statek 1 ---");
        statek1.WyswietlInformacje();

        Console.WriteLine("--- Statek 2 ---");
        statek2.WyswietlInformacje();

        // Opróżnienie kontenera gazowego
        kontenerGaz.OproznijLadunek();
        Console.WriteLine("\nPo opróżnieniu kontenera gazowego:");
        Console.WriteLine(kontenerGaz);

        // Próba przeładowania kontenera
        try
        {
            kontenerPlyny.ZaladujLadunek(6000); 
        }
        catch (WyjatekPrzeladowania ex)
        {
            Console.WriteLine("[Błąd] " + ex.Message);
        }
        }
    }
}
