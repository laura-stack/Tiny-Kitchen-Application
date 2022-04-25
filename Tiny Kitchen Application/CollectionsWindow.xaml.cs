using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
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
using System.Diagnostics;

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for CollectionsWindow.xaml
    /// </summary>
    /// 

    public class Collection
    {
        string name;
        List<Recipe> recipes;

        public Collection()
        {
            String name = "";
            recipes = new List<Recipe>();
        }

        public void setCollectionName(String n)
        {
            name = n;
        }

        public String getCollectionName()
        {
            return name;
        }

        public List<Recipe> getRecipes()
        {
            return recipes;
        }
        public void addRecipeToCollection(Collection c, Recipe r)
        {
            c.recipes.Add(r);
        }
    }
    public partial class CollectionsWindow : Window
    {

        public CollectionsWindow()
        {
            InitializeComponent();
        }

        public void CreateCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            Popup_Window.Visibility = System.Windows.Visibility.Visible;
            Popup_Window.IsOpen = true;
            //CreateCollection(); 
        }

        public void CreateCollection(String n)
        {
            string path1 = @"C:\Users\chach\source\repos\Tiny Kitchen Application\Tiny Kitchen Application\Collections";
            string path2 = System.IO.Path.Combine(path1, n);
            Collection collection = new Collection();
            collection.setCollectionName(n);

            // Create directory if it doesn't exist
            Directory.CreateDirectory(path2);
        }

        public void SaveCollectionName_Click(object sender, RoutedEventArgs e)
        {
            CreateCollection(collectionName.Text);
            Popup_Window.IsOpen = false;
        }

        public void ViewCollection_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDlg.ShowDialog();
        }

        public void DeleteCollection_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDlg.ShowDialog();
        }
        public void ExitCollectionCreator_Click(object sender, RoutedEventArgs e)
        {
            Popup_Window.IsOpen = false;
        }

        public void AddRecipeToCollection_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe_Popup.IsOpen = true;

            /*
            string msg = "";
            string[] rec = new string[Recipe.recipesList.Count];
            for(int i = 0; i < Recipe.recipesList.Count; i++)
            {
                rec[i] = Recipe.recipesList[i].RecipeName; 
            }
            
            foreach(string val in rec)
            {
                msg += val + "\n";
            }
            System.Windows.Forms.MessageBox.Show(msg);
            */
        }

        public void SaveRecipeAdd_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe_Popup.IsOpen = false;
            AddCollectionToAdd_Popup.IsOpen = true; 
        }

        public void ExitRecipeAdd_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe_Popup.IsOpen = false;
        }

        public void SaveCollectionAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCollectionToAdd_Popup.IsOpen = true;
        }

        public void ExitCollectionAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCollectionToAdd_Popup.IsOpen = false; 
        }

    }



}

