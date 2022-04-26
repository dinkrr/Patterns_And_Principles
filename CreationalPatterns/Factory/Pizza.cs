using System.Collections.Generic;

namespace CreationalPatterns.Factory
{
    public abstract class Pizza : IPizza
    {
        public IList<string> Toppings { get; }
        public DoughType Dough { get; set; }

        protected Pizza(IList<string> ingredients)
        {
            Toppings = ingredients;
        }
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }

    public class PizzaHut : Pizza
    {
        public PizzaHut(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Thin;
        }

        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }

    public class DominosPizza : Pizza
    {
        public DominosPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Pan;
        }
        public override void Bake() { }
        public override void Cut() { }
        public override void Box() { }
    }
}