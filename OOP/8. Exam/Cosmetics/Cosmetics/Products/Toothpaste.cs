namespace Cosmetics.Products
{
    using System.Text;
    using System.Collections.Generic;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product, IToothpaste
    {
        private const byte MinIngredientNameLength = 4;
        private const byte MaxIngredientNameLength = 12;

        private List<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
                : base(name, brand, price, gender)
        {
            this.IngredientsList = new List<string>(ingredients);
        }

        public List<string> IngredientsList
        {
            get
            {
                return new List<string>(this.ingredientsList);
            }
            private set
            {
                AreIngredientsNamesValid(value);

                this.ingredientsList = value;
            }
        }

        public string Ingredients
        {
            get 
            {
                return string.Join(", ", this.ingredientsList);
            }
        }

        private void AreIngredientsNamesValid(IEnumerable<string> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient, MaxIngredientNameLength, MinIngredientNameLength,
                                                     string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient ", MinIngredientNameLength, MaxIngredientNameLength));
            }
        }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("  * Ingredients: {0}", this.Ingredients));
            return base.Print() + result.ToString();
        }
    }
}
