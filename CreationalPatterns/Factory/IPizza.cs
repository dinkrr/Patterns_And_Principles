using System.Collections.Generic;

namespace CreationalPatterns.Factory
{
    public interface IPizza
    {
        IList<string> Toppings { get; }
        DoughType Dough { get; set; }
        void Bake();
        void Cut();
        void Box();
    }
}