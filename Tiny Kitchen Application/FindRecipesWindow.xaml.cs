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
                var endpoint = new Uri("https://api.edamam.com/api/recipes/v2?type=public&q=" + userQuery + "&app_id=" + appID + "&app_key=" + apiKey + "&field=uri&field=label&field=ingredients");
                var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                System.Windows.MessageBox.Show(result);
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
