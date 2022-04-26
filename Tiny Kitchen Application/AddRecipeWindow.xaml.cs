using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using System.Linq;

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        // Unsure if we will need these variables here.
        // Ingredients may need to be tweaked. 
        public static string recipeNameVar { get; set; }
        public static string ingredientsVar { get; set; }
        public static string cookTimeVar { get; set; }
        public static string caloriesVar { get; set; }
        public static string descriptionVar { get; set; }


        public AddRecipeWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = @"C:\Users\chach\source\repos\Tiny Kitchen Application\Tiny Kitchen Application\Recipes"
            };
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName,
                    "Name: " + recipeName.Text + '\n' +
                    "Ingredients: " + ingredients.Text + '\n' +
                    "Cook Time: " + cookTime.Text + '\n' +
                    "Calories: " + calories.Text + '\n' +
                    "Description: " + description.Text + '\n'
                    );

            Recipe recipeEx = new Recipe();
            recipeEx.RecipeName = recipeName.Text;
            recipeEx.CookTime = cookTime.Text;
            recipeEx.Calories = calories.Text;
            recipeEx.Description = description.Text;
            recipeEx.Ingredients = ingredients.Text;

            Recipe.recipesList.Add(recipeEx);

            // Create array of split recipe items
            Recipe.ingredientsList = ingredients.Text.Split(',');

            // Add that array to the list of ingredients lists
            Recipe.allIngredientsLists.Add(Recipe.ingredientsList);

            // Testing code to make sure the recipe arraylist works
            /*
            MessageBox.Show(string.Format("Your recipe: " + "\n"
                + "Name: " + recipeEx.RecipeName + "\n" +
                "CookTime: " + recipeEx.CookTime + "\n" +
                "Calories: " + recipeEx.Calories + "\n" +
                "Description: " + recipeEx.Description + "\n" +
                "ArrayList Object Count: " + Recipe.recipesList.Count + "\n" +
                )) ;
            */

            // Testing code to make sure that items are added in the individual
            // ingredients array using split

            /*
             MessageBox.Show(string.Format("Your ingredients for this recipe: " +
                Recipe.ingredientsList[0].ToString() + Recipe.ingredientsList[1].ToString()));
            */
        }

    }
}



