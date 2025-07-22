using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Storage<Produkt> produktStorage = new Storage<Produkt>();
	
	LäsInFrånFil(produktStorage);
	MataInProdukter(produktStorage);

	Console.WriteLine("\n---Här är alla rader som finns i filen:---");

	SkrivUtAlla(produktStorage);

        Console.WriteLine("Programmet avslutas.");
    }

    static void MataInProdukter(Storage<Produkt> storage)
    {
        while (true)

        {

            try
            {
                Console.Write("Skriv in nåt (eller 'stopp'): ");
                string namn = Console.ReadLine();
                if (namn.ToLower() == "stopp")
                    break;

		var produkt = new Produkt (namn);
		storage.LäggTill(new Produkt(namn));
		
		string rad = $"{produkt.Namn}";
 		File.AppendAllText("minData.txt", rad + Environment.NewLine);

            }
            catch (Exception)
            {
                Console.WriteLine("Du har skrivit fel.");
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
			string namn = rad.Trim();
            		if (!string.IsNullOrWhiteSpace(namn))
            		{ 
                    		var produkt = new Produkt(namn);
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
