namespace PracaDomowa1;

abstract class Konterer
{
   private static int licznikNumerow = 1;
   public string NumerSeryjny { get; protected set; } 
   public double MasaLadunku { get; protected set; }
   public double Wysokosc { get; protected set; } 
   public double WagaWlasna { get; protected set; } 
   public double Glebokosc { get; protected set; } 
   public double MaksymalnaLadownosc { get; protected set; }
   
   //konstruktor
   protected Kontener(string typ, double wysokosc, double wagaWlasna, double glebokosc, double maksymalnaLadownosc)
   {
      NumerSeryjny = $"KON-{typ}-{licznikNumerow++}";
      Wysokosc = wysokosc;
      WagaWlasna = wagaWlasna;
      Glebokosc = glebokosc;
      MaksymalnaLadownosc = maksymalnaLadownosc;
   }

   public abstract void ZaladujLadunek(double masa);
   public abstract void OproznijLadunek();

   public override string ToString() => $"Kontener {NumerSeryjny}: MasaLadunku={MasaLadunku}, MaksymalnaLadownosc={MaksymalnaLadownosc}";
}