public class Produkt
{
    public string Namn { get; set; }
    public double Pris { get; set; }

    public Produkt(string namn, double pris)
    {
        Namn = namn;
        Pris = pris;
    }

    public override string ToString()
    {
        return $"{Namn} - {Pris:C}";
    }
}