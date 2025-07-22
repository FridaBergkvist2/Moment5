using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Storage<Produkt> produktStorage = new Storage<Produkt>();
	{
	Läsinfrånfil(produktStorage)
	MataInProdukter(produktStorage);

	console.WriteLine("\n---Böcker jag lagt till---");


	SkrivUtAlla(produktStorage)

        Console.WriteLine("Programmet avslutas.");
    }

    static void MataInProdukter(Storage<Produkt> storage)
    {
        while (true)

        {

            try
            {
                Console.Write("Ange produktnamn (eller 'stopp'): ");
                string namn = Console.ReadLine();
                if (namn.ToLower() == "stopp")
                    break;

                Console.Write("Ange pris: ");
                double pris = Convert.ToDouble(Console.ReadLine());

		var produkt = new Produkt (namn, pris);
		storage.LäggTill(new Produkt(namn, pris));
		
		string rad = $"{produkt.Namn};{produkt.Pris}";
 		File.AppendAllText("testfil.txt", rad + Environment.NewLine);

            }
            catch (FormatException)
            {
                Console.WriteLine("Fel: Ange ett korrekt pris (t.ex. 199,50).");
            }
    static void LäsInFrånFil(Storage<Produkt> storage)
    	{
	if (File.Exists(textfil.txt)

        {

            try
            {
                Console.Write("Ange produktnamn (eller 'stopp'): ");
                string namn = Console.ReadLine();
                if (namn.ToLower() == "stopp")
                    break;

                Console.Write("Ange pris: ");
                double pris = Convert.ToDouble(Console.ReadLine());

		var produkt = new Produkt (namn, pris);
		storage.LäggTill(new Produkt(namn, pris));
		
		string rad = $"{produkt.Namn};{produkt.Pris}";
 		File.AppendAllText("testfil.txt", rad + Environment.NewLine);

            }
            catch (FormatException)
            {
                Console.WriteLine("Fel: Ange ett korrekt pris (t.ex. 199,50).");
            }
        }
        }
    }
}
