using System;
using System.Windows;

using System.Net.Http;

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
                var endpoint = new Uri("https://api.edamam.com/api/recipes/v2?type=public&q=" + userQuery + "&app_id=" + appID + "&app_key=" + apiKey + "&imageSize=REGULAR&field=label&field=image&field=url");
                var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                string label = "\"label\"";
                bool test = true;
                string[] perLabel;
                perLabel = result.Split(label); 
                while (test = true) {
                    int i = 0;
                    CustomDialog searching = new CustomDialog();
                    if (i < perLabel.Length)
                    {
                        string messageBoxText = perLabel[i + 1];
                        System.Windows.MessageBox.Show(messageBoxText);
                    }
                    else { test = false; }
                }
                

            }

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
