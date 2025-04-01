// Program.cs
namespace BurgerArchitectApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("===== BIENVENUE CHEZ BURGER ARCHITECT =====\n");

        bool continuer = true;
        while (continuer)
        {
            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("1. Commander un menu prédéfini");
            Console.WriteLine("2. Créer un burger personnalisé");
            Console.WriteLine("3. Quitter");
            Console.Write("\nVotre choix: ");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    CommanderMenu();
                    break;
                case "2":
                    CreerBurgerPersonnalise();
                    break;
                case "3":
                    continuer = false;
                    Console.WriteLine("\nMerci d'avoir utilisé Burger Architect. À bientôt !");
                    break;
                default:
                    Console.WriteLine("\nChoix invalide. Veuillez réessayer.\n");
                    break;
            }
        }
    }

    private static void CommanderMenu()
    {
        Console.WriteLine("\n=== COMMANDE DE MENU ===");
        Console.WriteLine("1. Menu Enfant");
        Console.WriteLine("2. Menu Standard");
        Console.WriteLine("3. Menu XL");
        Console.Write("\nChoisissez un menu: ");
        
        string choixMenu = Console.ReadLine();
        MenuFactory factory;
        
        switch (choixMenu)
        {
            case "1":
                factory = new MenuEnfantFactory();
                break;
            case "2":
                factory = new MenuStandardFactory();
                break;
            case "3":
                factory = new MenuXLFactory();
                break;
            default:
                Console.WriteLine("\nChoix invalide. Menu Standard sélectionné par défaut.\n");
                factory = new MenuStandardFactory();
                break;
        }
        
        Menu menu = factory.CreerMenu();
        menu.AfficherMenu();
        
        Console.WriteLine("\nCommande effectuée avec succès !\n");
    }

    private static void CreerBurgerPersonnalise()
    {
        Console.WriteLine("\n=== CRÉATION DE BURGER PERSONNALISÉ ===");
        
        BurgerBuilder builder = new BurgerBuilder();
        
        // Choix du pain
        Console.WriteLine("\nChoisissez votre pain:");
        Console.WriteLine("1. Pain blanc");
        Console.WriteLine("2. Pain complet");
        Console.Write("Votre choix: ");
        string choixPain = Console.ReadLine();
        
        if (choixPain == "2")
            builder.AvecPainComplet();
        else
            builder.AvecPainBlanc();
        
        // Choix de la viande
        Console.WriteLine("\nChoisissez votre viande:");
        Console.WriteLine("1. Bœuf");
        Console.WriteLine("2. Poulet");
        Console.WriteLine("3. Végétarien");
        Console.Write("Votre choix: ");
        string choixViande = Console.ReadLine();
        
        switch (choixViande)
        {
            case "1":
                builder.AvecViandeBoeuf();
                break;
            case "2":
                builder.AvecViandePoulet();
                break;
            case "3":
                builder.AvecViandeVegetarien();
                break;
            default:
                builder.AvecViandeBoeuf();
                break;
        }
        
        // Choix des accompagnements
        bool ajouterAccompagnements = true;
        while (ajouterAccompagnements)
        {
            Console.WriteLine("\nAjouter un accompagnement:");
            Console.WriteLine("1. Fromage");
            Console.WriteLine("2. Tomate");
            Console.WriteLine("3. Salade");
            Console.WriteLine("4. Oignon");
            Console.WriteLine("5. Sauce");
            Console.WriteLine("6. Terminer la personnalisation");
            Console.Write("Votre choix: ");
            
            string choixAccompagnement = Console.ReadLine();
            
            switch (choixAccompagnement)
            {
                case "1":
                    builder.AjouterFromage();
                    Console.WriteLine("Fromage ajouté !");
                    break;
                case "2":
                    builder.AjouterTomate();
                    Console.WriteLine("Tomate ajoutée !");
                    break;
                case "3":
                    builder.AjouterSalade();
                    Console.WriteLine("Salade ajoutée !");
                    break;
                case "4":
                    builder.AjouterOignon();
                    Console.WriteLine("Oignon ajouté !");
                    break;
                case "5":
                    Console.WriteLine("Choisissez votre sauce (ketchup, mayonnaise, barbecue): ");
                    string typeSauce = Console.ReadLine();
                    builder.AjouterSauce(typeSauce);
                    Console.WriteLine($"Sauce {typeSauce} ajoutée !");
                    break;
                case "6":
                    ajouterAccompagnements = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }
        }
        
        // Création et affichage du burger personnalisé
        Burger burger = builder.Build();
        Console.WriteLine("\nVotre burger personnalisé est prêt !");
        burger.AfficherDetails();
    }
}