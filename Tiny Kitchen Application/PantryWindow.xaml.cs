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

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for PantryWindow.xaml
    /// </summary>
    ///
    public class Pantry
    {
        ArrayList items;

        Pantry()
        {
            items = new ArrayList(); 
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
        public PantryWindow()
        {
            InitializeComponent();
        }


    }
}
