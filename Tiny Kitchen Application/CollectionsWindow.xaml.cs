﻿using System;
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
        string name; 
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

        }
    }
}
