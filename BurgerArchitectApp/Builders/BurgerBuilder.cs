using BurgerArchitectApp.Models;

namespace BurgerArchitectApp.Builders
{
    public class BurgerBuilder
    {
        private readonly Burger _burger = new();

        public BurgerBuilder SetPain(string pain)
        {
            _burger.Pain = pain;
            return this;
        }

        public BurgerBuilder SetViande(string viande)
        {
            _burger.Viande = viande;
            return this;
        }

        public BurgerBuilder AddAccompagnement(string accompagnement)
        {
            _burger.Accompagnements.Add(accompagnement);
            return this;
        }

        public Burger Build()
        {
            return _burger;
        }
    }
}
