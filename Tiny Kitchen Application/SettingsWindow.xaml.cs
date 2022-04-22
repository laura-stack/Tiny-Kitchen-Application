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

        public static string emailProvider { get; set; }

        public static bool calorieToggle { get; set; }

        public SettingsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            if (MyCombobox1.SelectedItem != null)
            {
                //ComboBoxItem cbi1 = (ComboBoxItem)(sender as ComboBox).SelectedItem;
                ComboBoxItem cbi = (ComboBoxItem)MyCombobox1.SelectedItem;
                emailProvider = cbi.Content.ToString();
            }
            MessageBox.Show(string.Format("Settings saved successfully.\n" + 
                "Your current email provider is: " + emailProvider + "\n"+
                "Calories turned off? " + calorieToggle));
        }

    }

}