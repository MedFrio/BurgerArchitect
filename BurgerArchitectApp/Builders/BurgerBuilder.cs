// BurgerBuilder.cs
namespace BurgerArchitectApp;

public class BurgerBuilder
{
    private Burger _burger = new Burger();

    // Méthodes pour configurer le pain
    public BurgerBuilder AvecPainBlanc()
    {
        _burger.TypePain = "Pain blanc";
        return this;
    }

    public BurgerBuilder AvecPainComplet()
    {
        _burger.TypePain = "Pain complet";
        return this;
    }

    // Méthodes pour configurer la viande
    public BurgerBuilder AvecViandeBoeuf()
    {
        _burger.TypeViande = "Boeuf";
        return this;
    }

    public BurgerBuilder AvecViandePoulet()
    {
        _burger.TypeViande = "Poulet";
        return this;
    }

    public BurgerBuilder AvecViandeVegetarien()
    {
        _burger.TypeViande = "Galette végétarienne";
        return this;
    }

    // Méthodes pour ajouter des accompagnements
    public BurgerBuilder AjouterFromage()
    {
        _burger.Accompagnements.Add("Fromage");
        return this;
    }

    public BurgerBuilder AjouterTomate()
    {
        _burger.Accompagnements.Add("Tomate");
        return this;
    }

    public BurgerBuilder AjouterSalade()
    {
        _burger.Accompagnements.Add("Salade");
        return this;
    }

    public BurgerBuilder AjouterOignon()
    {
        _burger.Accompagnements.Add("Oignon");
        return this;
    }

    public BurgerBuilder AjouterSauce(string typeSauce)
    {
        _burger.Accompagnements.Add($"Sauce {typeSauce}");
        return this;
    }

    // Méthode finale pour construire et retourner le burger
    public Burger Build()
    {
        return _burger;
    }
}