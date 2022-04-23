using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Tiny_Kitchen_Application
{
    internal class Recipe : IRecipe
    {
        public static string _recipeName { get; set; }
        public static string _cookTime { get; set; }
        public static string _calories { get; set; }
        public static string _description { get; set; }

        // Unedited string of ingredients related to the recipe object; 
        // What is typed in raw by user in AddRecipeWindow
        public static string _ingredients { get; set; } 

        // List of recipes added by user; recipe objects have all properties in this class
        public static List<Recipe> recipesList = new List<Recipe>();

        // List of all ingredients arrays; aligns with recipesList array number
        // Ex. Recipe list at [5] will align with ingredients list at [5]
        public static List<Object> allIngredientsLists = new List<Object>();

        // Edited ingredients array based off of raw user typing; split by comma
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
