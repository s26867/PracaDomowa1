namespace PracaDomowa1
{

    class Program
    {
        static void Main(string[] args)
        {
            StatekKontenerowy statek = new StatekKontenerowy(25, 10, 100000);
            KontenerNaPlyny kontener1 = new KontenerNaPlyny(250, 500, 300, 10000, true);
            try
            {
                kontener1.ZaladujLadunek(4000);
                statek.ZaladujKontener(kontener1);
            }
            catch (WyjatekPrzeladowania ex)
            {
                Console.WriteLine($"Blad: {ex.Message}");
            }

            statek.WyswietlInformacje();
        }
    }
}
