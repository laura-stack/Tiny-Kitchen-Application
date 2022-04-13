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

namespace Tiny_Kitchen_Application
{
    /// <summary>
    /// Interaction logic for RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public RecipeWindow()
        {
            InitializeComponent();
        }

        public void createButton() { 
            Button btn = new Button();

            btn.Height = 80;

            btn.Width = 150;

            btn.Content = "Click ME";
            btn.Background = new SolidColorBrush(Colors.Orange);
            btn.Foreground = new SolidColorBrush(Colors.Black);
        }

       
    }
}
