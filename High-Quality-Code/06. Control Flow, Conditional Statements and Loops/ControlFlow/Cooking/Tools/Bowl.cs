namespace Cooking.Tools
{
    using System.Collections.Generic;
    using Ingredients;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public ICollection<Vegetable> Ingredients { get; private set; }

        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public void Cook()
        {
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.Cook();
            }
        }

        public override string ToString()
        {
            return string.Join("\n", this.Ingredients);
        }
    }
}
