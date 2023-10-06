using System;

class Program
{
    static void Main()
    {
        Console.Write("Hur många timmar vill du hyra bilen? ");
        int antalTimmar = int.Parse(Console.ReadLine());

        int timpris = 80;
        int maximaltBeloppPerDag = 950;
        int kostnad;

        if (antalTimmar > 24)
        {
            Console.WriteLine("Du kan inte hyra bilen i mer än 24 timmar.");
        }
        else
        {
            kostnad = antalTimmar * timpris;
            if (kostnad > maximaltBeloppPerDag)
            {
                kostnad = maximaltBeloppPerDag;
            }
            Console.WriteLine($"Kostnaden för att hyra bilen i {antalTimmar} timmar är {kostnad} kr.");
        }
    }
}
