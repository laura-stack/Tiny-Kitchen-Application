using System;
using System.Windows;
using System.Net.Http;
using System.Linq;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System.IO;

namespace Tiny_Kitchen_Application
{

    public partial class FindRecipesWindow : Window
    {

        string concernLink = "&health=";
        string concern = "";
        string items = "";
        string calAddOn = "&field=calories";




        public string userQuery { get; set; }
        public FindRecipesWindow()
        {
            InitializeComponent();
        }


        private void initiateSearch(object sender, RoutedEventArgs e)
        {
            string userQuery = Inputquery.Text;
            string appID = "faef1f70";
            string apiKey = "382682029b8bfe878596ffd8332acfd6";
            items = FormatIng(items);
            using (var client = new HttpClient())
            {
                
                var endpoint = new Uri("https://api.edamam.com/api/recipes/v2?type=public&q=" + userQuery + "&app_id=" + appID + "&app_key=" + apiKey +items+concern+"&imageSize=SMALL&field=label&field=image&field=url&field=ingredientLines"+calAddOn);
                var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                //Create a JObject from the string jsonResponse
                JObject recipes = JObject.Parse(result);

                //Create a JArray from a key element in the JSON(hits)
                //hits is a JSON Array of objects
                JArray recipeArr = JArray.Parse(recipes["hits"].ToString());
                CustomDialog searching = new CustomDialog();
                //Loop through all of the objects found in recipes["hits"]
                for (var i = 0; i < recipeArr.Count(); ++i)
                {

                    if (searching.GetContinue() == true)
                    {
                        if (searching.GetSave() == false)
                        {
                            string toFormat = recipeArr[i].ToString();

                            if (calAddOn != string.Empty)
                            {
                                //MessageBox.Show(toFormat);
                                string[] formatted = getInfo(toFormat);
                                string rLabel = formatted[0];
                                string ingList = formatted[1];
                                string rLink = formatted[2];
                                string rPic = formatted[3];
                                string cal = "Calories: "+formatted[4];
                                searching.SetBox(rLabel, ingList, rLink, rPic, cal);
                                searching.ShowDialog();
                                if (searching.GetSave() == true)
                                {

                                    SaveAPIRec(rLabel, ingList, rLink, cal); ;
                                    searching.SetContinue(false);
                                }
                            }
                            else if (calAddOn == string.Empty)
                            {
                                string[] formatted = getInfo(toFormat);
                                string rLabel = formatted[0];
                                string ingList = formatted[1];
                                string rLink = formatted[2];
                                string rPic = formatted[3];
                                string cal2 = "";
                                searching.SetBox(rLabel, ingList, rLink, rPic, cal2);
                                searching.ShowDialog();
                                if (searching.GetSave() == true)
                                {

                                    SaveAPIRec(rLabel, ingList, rLink, cal2);
                                    searching.SetContinue(false);
                                }

                            }

                        }
                    }
                    else { }

                }
            }
        }
            private string[] getInfo(string apiText)
            {
            if (calAddOn != string.Empty)
            {
                int indexOfLabel = apiText.IndexOf("label\":");
                int indexOfImage = apiText.IndexOf("image\":");
                string label = apiText.Substring(indexOfLabel + 9, indexOfImage - indexOfLabel - 18);
                string[] byHeader = new string[5];
                byHeader[0] = label;
                int indexOfUrl = apiText.IndexOf("url\":");
                string img = apiText.Substring(indexOfImage + 9, indexOfUrl - indexOfImage - 18);
                byHeader[3] = img;
                int indexOfIng = apiText.IndexOf("Lines\":");
                int indexOfEnd = apiText.IndexOf("_links\":");
                string ingLines = apiText.Substring(indexOfIng + 10, indexOfEnd - indexOfIng - 24);
                byHeader[1] = ingLines;
                string url = apiText.Substring(indexOfUrl + 7, indexOfIng - indexOfUrl - 26);
                byHeader[2] = url;
                int indexOfCal = apiText.IndexOf("calories\":");
                string cal = apiText.Substring(indexOfCal+10, indexOfEnd - indexOfCal - 18);
                byHeader[4] = cal;
                return byHeader;
            }
            else
            {
                int indexOfLabel = apiText.IndexOf("label\":");
                int indexOfImage = apiText.IndexOf("image\":");
                string label = apiText.Substring(indexOfLabel + 9, indexOfImage - indexOfLabel - 18);
                string[] byHeader = new string[5];
                byHeader[0] = label;
                int indexOfUrl = apiText.IndexOf("url\":");
                string img = apiText.Substring(indexOfImage + 9, indexOfUrl - indexOfImage - 18);
                byHeader[3] = img;
                int indexOfIng = apiText.IndexOf("Lines\":");
                int indexOfEnd = apiText.IndexOf("_links\":");
                string ingLines = apiText.Substring(indexOfIng + 10, indexOfEnd - indexOfIng - 24);
                byHeader[1] = ingLines;
                string url = apiText.Substring(indexOfUrl + 7, indexOfIng - indexOfUrl - 26);
                byHeader[2] = url;
                return byHeader;

            }

            
        }
        public void SaveAPIRec(string message, string list, string link, string cal)
        {
            string directory = @"C:\Users\justi\source\repos\Tiny-Kitchen-ApplicationMON\Tiny Kitchen Application\Recipes";
            string filename = message;
            string path = Path.Combine(directory, filename + ".txt");

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
                {
                sw.WriteLine("Name: " + message + '\n' +
            "Ingredients: " + list + '\n' +
            "Url: " + link + '\n'
             + cal
            );
                sw.Close();
            }

            Recipe recipeEx = new Recipe();
            recipeEx.RecipeName = message;
            recipeEx.CookTime = "";
            recipeEx.Calories = "";
            recipeEx.Description = "";
            recipeEx.Ingredients = list;

            Recipe.recipesList.Add(recipeEx);
        }

        private string FormatIng(string items)
        {
            if (ExcludeItems.Text != string.Empty)
            {
                items = "&ingr=";
                items = items+ExcludeItems.Text;
                return items;
            }
            return items;
        }

    

        private void Vegan_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
            concern = concernLink + "vegan";
        }

        private void Cal_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            calAddOn = "";
        }

        private void DF_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            concern = concernLink + "dairy-free";
        }

        private void Keto_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            concern = concernLink + "keto";
        }

        private void Kosher_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            concern = concernLink + "kosher";
        }

        private void Vegge_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            concern = concernLink + "vegetarian";
        }
    }
}
