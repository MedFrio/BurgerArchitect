using System.Collections.Generic;
using System;

namespace BurgerArchitectApp;

public class Burger
{
    public string TypePain { get; set; } = string.Empty;
    public string TypeViande { get; set; } = string.Empty;
    public List<string> Accompagnements { get; set; } = new List<string>();

    public void AfficherDetails()
    {
        Console.WriteLine("\n=== DÉTAILS DU BURGER ===");
        Console.WriteLine($"Pain: {TypePain}");
        Console.WriteLine($"Viande: {TypeViande}");
        Console.WriteLine("Accompagnements:");

        if (Accompagnements.Count > 0)
        {
            foreach (var accompagnement in Accompagnements)
            {
                Console.WriteLine($"- {accompagnement}");
            }
        }
        else
        {
            Console.WriteLine("- Aucun accompagnement");
        }

        Console.WriteLine("=======================\n");
    }
}
