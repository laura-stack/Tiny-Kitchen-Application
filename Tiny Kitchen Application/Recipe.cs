using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tiny_Kitchen_Application
{
    internal class Recipe : IRecipe
    {
        public static string _recipeName { get; set; }
        //Recipe._recipeName

        public static ArrayList _ingredients { get; set; }
        public static string _cookTime { get; set; }
        public static string _calories { get; set; }
        public static string _description { get; set; }
        public static string _fileName { get; set; }

        /*public string FileName
        {
            get
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true) { 
                    sample.Text = File.ReadAllText(openFileDialog.FileName);
                }
                return _fileName;
            }
                
            set
            {
                _fileName = value;
            }
        }*/

        public string RecipeName
        {
            get
            {
                return _recipeName;
            }
            set
            {
                string NewLine = "";
                using (StreamReader steamReader = new StreamReader(_fileName))
                {
                    if (!NewLine.Contains("Recipe Cook Time:"))
                    {
                        _recipeName = steamReader.ReadToEnd();
                    }

                }

                _recipeName = value;
            }
        }

        public ArrayList Ingredients
        {
            get
            {
                return _ingredients;
            }

            set
            {
                string NewLine = "";
                using (StreamReader steamReader = new StreamReader(_fileName))
                {
                    if (!NewLine.Contains("Recipe Description:"))
                    {
                        _recipeName = steamReader.ReadToEnd();
                    }

                }

                _ingredients = value;
            }
        }

        public string CookTime
        {
            get
            {
                return _cookTime;
            }

            set
            {
                string NewLine = "";
                using (StreamReader steamReader = new StreamReader(_fileName))
                {
                    if (!NewLine.Contains("Recipe Ingredients:"))
                    {
                        _cookTime = steamReader.ReadToEnd();
                    }

                }

                _cookTime = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                string NewLine = "";
                using (StreamReader steamReader = new StreamReader(_fileName))
                {
                    if (!NewLine.Contains("Recipe Calories:"))
                    {
                        _recipeName = steamReader.ReadToEnd();
                    }

                }

                _description = value;
            }
        }
        public string Calories
        {
            get
            {
                return _calories;
            }

            set
            {
                using (StreamReader steamReader = new StreamReader(_fileName))
                {
                   _calories = steamReader.ReadToEnd();
                }

                _calories = value;
            }
        }


    }
}
