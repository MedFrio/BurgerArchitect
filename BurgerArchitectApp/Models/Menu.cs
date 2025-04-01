// Menu.cs
namespace BurgerArchitectApp;

public class Menu
{
    public string Nom { get; set; }
    public Burger Burger { get; set; }
    public string Boisson { get; set; }
    public string Frites { get; set; }

    public void AfficherMenu()
    {
        Console.WriteLine($"\n*** MENU {Nom.ToUpper()} ***");
        Console.WriteLine($"Boisson: {Boisson}");
        Console.WriteLine($"Frites: {Frites}");
        Burger.AfficherDetails();
    }
}