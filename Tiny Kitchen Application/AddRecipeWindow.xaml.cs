﻿using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
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
using System.IO;


namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        public AddRecipeWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
            File.WriteAllText(saveFileDialog.FileName, name.Text + description.Text);
            }
        /*using (StreamWriter writetext = new StreamWriter("file", append: true))
            {
                writetext.WriteLine(emailAddress);
            }*/
    }

}



