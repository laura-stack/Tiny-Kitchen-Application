using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for PantryWindow.xaml
    /// </summary>
    ///

    public class Pantry
    {

        ArrayList items;

        public Pantry()
        {
            items = new ArrayList();
        }

        public ArrayList getItems()
        {
            return items;
        }
        public void AddItem(String item)
        {
            items.Add(item);
        }

        public void DeleteItem(String item)
        {
            items.Remove(item);
        }

    }

    public partial class PantryWindow : Window
    {
        Pantry pantry = new Pantry();
        //public System.Windows.Forms.ListBox.ObjectCollection Items { get; }
        //ListBox listbox = new ListBox(); 

        string path = @"C:\Users\chach\source\repos\Tiny Kitchen Application\Tiny Kitchen Application\Pantry.txt";
        public PantryWindow()
        {
            InitializeComponent();
        }

        public void AddToPantry_Click(object sender, RoutedEventArgs e)
        {
            Pantry_Popup.IsOpen = true;
        }

        public void SaveItem_Click(object sender, RoutedEventArgs e)
        {
            pantry.AddItem(pantryItem.Text);
            Pantry_Popup.IsOpen = false;

            AddPantryItem();
        }

        public void AddPantryItem()
        {

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(pantryItem.Text);
            }
        }

        // public void 

        public void ExitPantryAdd_Click(object sender, RoutedEventArgs e)
        {
            Pantry_Popup.IsOpen = false;
        }


    }
}
