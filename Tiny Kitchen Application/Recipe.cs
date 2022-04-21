using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Tiny_Kitchen_Application
{
    // I am unsure if we need this class. 
    internal class Recipe : IRecipe
    {
        public static string _recipeName { get; set; }
        public static string _cookTime { get; set; }
        public static string _calories { get; set; }
        public static string _description { get; set; }

        public static string _ingredients { get; set; } 

        public static List<Recipe> recipesList = new List<Recipe>();

        public static string[] ingredientsList;

        public string RecipeName  
        {
            get { return _recipeName; } 
            set { _recipeName = value; }  
        }

        public string CookTime
        {
            get { return _cookTime; }
            set { _cookTime = value; }
        }

        public string Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

    }
      
}
