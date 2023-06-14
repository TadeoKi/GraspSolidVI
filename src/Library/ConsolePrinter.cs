using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        // Modificado por DIP
        public void PrintRecipe(IRecipeContent recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}