using System;
using System.Windows;
using System.Net.Http;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Tiny_Kitchen_Application
{

    public partial class FindRecipesWindow : Window
    {
        Boolean isVegan;
        
      
        public string userQuery { get; set; }
        public FindRecipesWindow()
        {
            InitializeComponent();
        }


        private void initiateSearch(object sender, RoutedEventArgs e)
        {
            String userQuery = Inputquery.Text;
            string appID = "faef1f70";
            string apiKey = "382682029b8bfe878596ffd8332acfd6";
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://api.edamam.com/api/recipes/v2?type=public&q=" + userQuery + "&app_id=" + appID + "&app_key=" + apiKey + "&imageSize=SMALL&field=label&field=image&field=url&field=ingredientLines");
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

                    if (searching.GetBox() == true)
                    {
                        string toFormat = recipeArr[i].ToString();

                        string[] formatted = getInfo(toFormat);

                        string rLabel = formatted[0];
                        string ingList = formatted[1];
                        string rLink = formatted[2];
                        string rPic = formatted[3];
                        searching.SetBox(rLabel, ingList, rLink, rPic);
                        searching.ShowDialog();


                    }
                    else
                    {

                    }

                }
            }
        }
            private string[] getInfo(string apiText)
            {
                int indexOfLabel = apiText.IndexOf("label\":");
                int indexOfImage = apiText.IndexOf("image\":");
                string label = apiText.Substring(indexOfLabel + 9, indexOfImage-indexOfLabel-18);
                string[] byHeader = new string[4];
                byHeader[0] = label;
                int indexOfUrl=apiText.IndexOf("url\":");
                string img = apiText.Substring(indexOfImage + 9, indexOfUrl - indexOfImage-18);
                byHeader[3] = img;
                int indexOfIng=apiText.IndexOf("Lines\":");
                int indexOfEnd=apiText.IndexOf("_links\":");
                string ingLines=apiText.Substring(indexOfIng+10, indexOfEnd-indexOfIng-24);
                byHeader[1] = ingLines;
                string url = apiText.Substring(indexOfUrl + 7, indexOfIng - indexOfUrl - 26);
                byHeader[2] = url;
           
                return byHeader;

            
        }

        private void Vegan_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            isVegan = true;
        }
        private void Vegan_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            isVegan = false;
        }
    }
}
