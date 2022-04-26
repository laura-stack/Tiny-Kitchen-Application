using System;
using System.Linq;
using System.Collections;
using System.Diagnostics;
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
using System.Windows.Forms;

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for PantryWindow.xaml
    /// </summary>
    ///

    public class Pantry
    {

        public ArrayList itemsInPantry;

        public Pantry()
        {
            itemsInPantry = new ArrayList();
        }

        public ArrayList getItems()
        {
            return itemsInPantry;
        }
        public void AddItem(String item)
        {
            itemsInPantry.Add(item);
        }

        public void DeleteItem(String item)
        {
            itemsInPantry.Remove(item);
        }

    }

    public partial class PantryWindow : Window
    {
        Pantry pantry = new Pantry();
        int i = 0;
        public ArrayList itemsInPantry;
        //public System.Windows.Forms.ListBox.ObjectCollection Items { get; }
        //ListBox listbox = new ListBox(); 

        string path = @"C:\Users\chach\source\repos\Tiny Kitchen Application\Tiny Kitchen Application\Pantry\Pantry.txt";
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
            itemsInPantry = new ArrayList();
            AddPantryItem();
        }

        public void AddPantryItem()
        {
            itemsInPantry.Add(pantryItem.Text);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(pantryItem.Text);
            }
        }

        public void RemovePantryItem()
        {
            pantry.DeleteItem(removeItem.Text);
            List<String> lines = new List<String>();
            lines = File.ReadAllLines(path).ToList();

            string item = removeItem.Text;
           
            itemsInPantry.Remove(removeItem.Text);

            var newLines = lines.Where(line => !line.Contains(item, StringComparison.OrdinalIgnoreCase));
            File.WriteAllLines(path, newLines);
        }

        public void DeletePantryItem_Click(object sender, RoutedEventArgs e)
        {
            RemoveItem_Popup.IsOpen = true;
        }

        public void SaveRemoval_Click(object sender, RoutedEventArgs e)
        {
            RemovePantryItem();
            RemoveItem_Popup.IsOpen = false;
        }

        public void ExitPantryRemoval_Click(object sender, RoutedEventArgs e)
        {
            RemoveItem_Popup.IsOpen = false;
        }

        // public void 

        public void ExitPantryAdd_Click(object sender, RoutedEventArgs e)
        {
            Pantry_Popup.IsOpen = false;
        }

        public void ViewPantry_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new System.Windows.Forms.OpenFileDialog()
            {
                InitialDirectory = @"C:\Users\chach\source\repos\Tiny Kitchen Application\Tiny Kitchen Application\Pantry"
            };
            openFile.ShowDialog();
        }
            
        }


    }

