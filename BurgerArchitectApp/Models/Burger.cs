// Burger.cs
namespace BurgerArchitectApp;

public class Burger
{
    // Propriétés du burger
    public string TypePain { get; set; }
    public string TypeViande { get; set; }
    public List<string> Accompagnements { get; set; } = new List<string>();

    // Méthode pour afficher les détails du burger
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