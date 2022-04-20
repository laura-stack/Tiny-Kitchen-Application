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

namespace Tiny_Kitchen_Application
{
     private string appID= "faef1f70";
        private string apiKey="382682029b8bfe878596ffd8332acfd6"; 
        async function sendApiRequest(){
            response = await fetch("https://api.edamam.com/api/recipes/v2?app_id="+appID+"app_key="+apiKey);
            console.log(response); 
         }
    public partial class FindRecipesWindow : Window
    {
        public FindRecipesWindow()
        {
            InitializeComponent();
        }
    }
}
