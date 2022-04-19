using System;
using System.IO;
using Microsoft.Win32;
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

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for CollectionsWindow.xaml
    /// </summary>
    /// 

    public class Collection
    {
        //string name; 
        //ArrayList<Recipes> recipes;

        public Collection()
        {
            String name;
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
            //Popup_Window.Visibility = System.Windows.Visibility.Visible;
             Popup_Window.IsOpen = true; 
            //CreateCollection(); 
        }

        public void CreateCollection()
        {
            string path1 = @"C:\Users\chach\source\repos\Tiny-Kitchen-Application\Tiny Kitchen Application\Collections";
            string path2 = System.IO.Path.Combine(path1, "temp2");

            // Create directory temp1 if it doesn't exist
            Directory.CreateDirectory(path2);
        }
    }
}
