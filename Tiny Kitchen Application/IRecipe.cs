﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tiny_Kitchen_Application
{
    internal interface IRecipe
    {
        string RecipeName { get; set; }
        ArrayList Ingredients { get; set; }
        double CookTime { get; set; }
        string Calories { get; set; }
        string Description { get; set; }
        //string FileName { get; set; }
        

        public void deleteRecipe(string fileName, LinkedList<string> Recipes)
        {
            /** This may need to be changed later to ensure we delete
            * the correct directory.
            * See: https://wpf-tutorial.com/dialogs/the-savefiledialog/#aelm809
            */

            File.Delete(fileName);
            Recipes.RemoveLast();
        }

    }
}
