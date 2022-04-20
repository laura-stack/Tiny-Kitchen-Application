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
        //ArrayList<Recipes> recipes;

        public Collection()
        {
            String name = "";
        }

        public void setCollectionName(String n)
        {
            name = n;
        }

        public String getCollectionName()
        {
            return name;
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

       
    }
   

    
}

