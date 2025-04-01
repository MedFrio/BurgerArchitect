using System.Collections.Generic;

namespace BurgerArchitectApp.Models
{
    public class Burger
    {
        public string? Pain { get; set; }
        public string? Viande { get; set; }

        public List<string> Accompagnements { get; set; } = new();

        public override string ToString()
        {
            var acc = Accompagnements.Count > 0 ? string.Join(", ", Accompagnements) : "Aucun";
            return $"Burger avec pain: {Pain}, viande: {Viande}, accompagnements: {acc}";
        }
    }
}
