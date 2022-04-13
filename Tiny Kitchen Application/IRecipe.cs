using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tiny_Kitchen_Application
{
    internal interface IRecipe
    {
        string Name { get; set; }
        ArrayList Ingredients { get; set; }
        double cookTime { get; set; }
        double Calories { get; set; }
        string Description { get; set; }

        string fileName { get; set; }

        public void deleteRecipe(string fileName, LinkedList<string> Recipes)
        {

        }

        public void editRecipe(string fileName, LinkedList<string> Recipes)
        {

        }


    }
}
