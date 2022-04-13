using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tiny_Kitchen_Application
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void RecipeButton_Click(object sender, RoutedEventArgs e)
		{
			RecipeWindow recipeWindow = new RecipeWindow();
			recipeWindow.Show();
			recipeWindow.Width = 450;
			recipeWindow.Height = 450;

		}

		private void FindRecipeButton_Click(object sender, RoutedEventArgs e)
        {
			FindRecipesWindow findRecipesWindow = new FindRecipesWindow();
			findRecipesWindow.Show();
			findRecipesWindow.Width = 450;
			findRecipesWindow.Height = 450; 
        }

		public void CollectionsButton_Click(object sender, RoutedEventArgs e)
        {
			CollectionsWindow collectionWindow = new CollectionsWindow();
			collectionWindow.Show();
			collectionWindow.Width = 450;
			collectionWindow.Height = 450; 
        }

		public void PantryButton_Click(object sender, RoutedEventArgs e)
        {
			PantryWindow pantryWindow = new PantryWindow();
			pantryWindow.Show();
			pantryWindow.Width = 450;
			pantryWindow.Height = 450; 
        }
		
		public void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
			SettingsWindow settingsWindow = new SettingsWindow();
			settingsWindow.Show();
			settingsWindow.Height = 450;
			settingsWindow.Width = 450; 
        }

		public void ShareButton_Click(object sender, RoutedEventArgs e)
		{
			ShareWindow shareWindow = new ShareWindow();
			shareWindow.Show();
			shareWindow.Height = 450;
			shareWindow.Width = 450;
		}

		public void CalendarButton_Click(object sender, RoutedEventArgs e)
		{
			CalendarWindow calendarWindow = new CalendarWindow();
			calendarWindow.Show();
			calendarWindow.Height = 450;
			calendarWindow.Width = 450;
		}
		public void ShoppingListButton_Click(object sender, RoutedEventArgs e)
		{
			ShoppingListWindow shoppingListWindow = new ShoppingListWindow();
			shoppingListWindow.Show();
			shoppingListWindow.Height = 450;
			shoppingListWindow.Width = 450;
		}




	}
}
