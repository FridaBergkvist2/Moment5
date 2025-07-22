public class Produkt
{
    public string Namn { get; set; }

    public Produkt(string namn)
    {
        Namn = namn;
    }

    public override string ToString()
    {
        return $"{Namn}";
    }
}