namespace PracaDomowa1;

public class WyjatekPrzeladowania : Exception
{
    public WyjatekPrzeladowania(string wiadomosc) : base(wiadomosc) { }
}