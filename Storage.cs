using System;
using System.Collections.Generic;

public class Storage<B>
{
    private List<B> lista = new List<B>();

public int Antal
{
    get { return lista.Count; }
}
    
public void LäggTill(B objekt)
    {
        lista.Add(objekt);
    }

    public void SkrivUtAlla()
    {
        Console.WriteLine("Innehåll i Storage:");
        foreach (B objekt in lista)
        {
            Console.WriteLine(objekt);
        }
    }
}
