// MenuFactory.cs
namespace BurgerArchitectApp;

// Interface pour la Factory Method
public abstract class MenuFactory
{
    public abstract Menu CreerMenu();
}

// Implémentation concrète pour le Menu Enfant
public class MenuEnfantFactory : MenuFactory
{
    public override Menu CreerMenu()
    {
        // Création du burger pour enfant
        Burger burger = new BurgerBuilder()
            .AvecPainBlanc()
            .AvecViandePoulet()
            .AjouterFromage()
            .AjouterSauce("ketchup")
            .Build();

        // Création du menu enfant
        return new Menu
        {
            Nom = "Enfant",
            Burger = burger,
            Boisson = "Jus de fruits 25cl",
            Frites = "Petite portion de frites"
        };
    }
}

// Implémentation concrète pour le Menu Standard
public class MenuStandardFactory : MenuFactory
{
    public override Menu CreerMenu()
    {
        // Création du burger standard
        Burger burger = new BurgerBuilder()
            .AvecPainBlanc()
            .AvecViandeBoeuf()
            .AjouterFromage()
            .AjouterTomate()
            .AjouterSalade()
            .AjouterSauce("mayonnaise")
            .Build();

        // Création du menu standard
        return new Menu
        {
            Nom = "Standard",
            Burger = burger,
            Boisson = "Soda 33cl",
            Frites = "Portion moyenne de frites"
        };
    }
}

// Implémentation concrète pour le Menu XL
public class MenuXLFactory : MenuFactory
{
    public override Menu CreerMenu()
    {
        // Création du burger XL
        Burger burger = new BurgerBuilder()
            .AvecPainComplet()
            .AvecViandeBoeuf()
            .AjouterFromage()
            .AjouterFromage() // Double fromage
            .AjouterTomate()
            .AjouterSalade()
            .AjouterOignon()
            .AjouterSauce("barbecue")
            .Build();

        // Création du menu XL
        return new Menu
        {
            Nom = "XL",
            Burger = burger,
            Boisson = "Soda 50cl",
            Frites = "Grande portion de frites"
        };
    }
}