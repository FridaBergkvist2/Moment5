using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Storage<Produkt> produktStorage = new Storage<Produkt>();
	
	LäsInFrånFil(produktStorage);
	MataInProdukter(produktStorage);

	Console.WriteLine("\n---Böcker jag lagt till---");

	SkrivUtAlla(produktStorage);

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
 		File.AppendAllText("minData.txt", rad + Environment.NewLine);

            }
            catch (FormatException)
            {
                Console.WriteLine("Fel: Ange ett korrekt pris (t.ex. 199,50).");
            }
  	}
    }

    
   static void LäsInFrånFil(Storage<Produkt> storage)
    	{
	    if (File.Exists("minData.txt"))

            {
		string[] rader = File.ReadAllLines("minData.txt");
		foreach (string rad in rader)
            	{
			string[] delar = rad.Split(';');
			if (delar.Length == 2 && double.TryParse(delar[1], out double pris))
            		{ 
                   		string namn = delar[0];
                    		var produkt = new Produkt(namn, pris);
                    		storage.LäggTill(produkt);
            		}
            	}
            }
 	}
    static void SkrivUtAlla(Storage<Produkt> storage)
    	{
	    Console.WriteLine($"Antal: {storage.Antal}");
	    storage.SkrivUtAlla();

    	}
}
