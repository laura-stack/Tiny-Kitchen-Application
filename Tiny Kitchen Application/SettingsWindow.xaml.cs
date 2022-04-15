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
using Microsoft.Win32;

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {

        public static string emailAddress { get; set; }

        public static bool calorieToggle { get; set; }

        public SettingsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        // Need to come back to this in order to bind textbox email to variable

        //private void SaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //emailAddress = emailAddress.Text;
        //MessageBox.Show(emailAddress);
        //}
    }

}