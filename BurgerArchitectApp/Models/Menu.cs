using System;

namespace BurgerArchitectApp;

public class Menu
{
    public string Nom { get; set; } = string.Empty;
    public Burger Burger { get; set; } = new();
    public string Boisson { get; set; } = string.Empty;
    public string Frites { get; set; } = string.Empty;

    public void AfficherMenu()
    {
        Console.WriteLine($"\n*** MENU {Nom.ToUpper()} ***");
        Console.WriteLine($"Boisson: {Boisson}");
        Console.WriteLine($"Frites: {Frites}");
        Burger.AfficherDetails();
    }
}
