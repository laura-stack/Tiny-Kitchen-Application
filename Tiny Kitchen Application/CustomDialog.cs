using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tiny_Kitchen_Application
{
    public partial class CustomDialog : Form
    {
        public CustomDialog()
        {
            InitializeComponent();
        }
        string add = "Add to Collection";
        string next = "Next Recipe";
        public CustomDialog(string message, string list, string link, string picLink)
        {
            button1.Text = add;
            button2.Text = next;
            label1.Text = message;
            listBox1.Text = list;
            linkLabel1.Text = link;
            pictureBox2.LoadAsync(picLink);

        }

        private void addToCollection_Click(object sender, EventArgs e)
        {
            //add to collection
            System.Windows.MessageBox.Show("Saved!"); 
        }

        private void nextRecipe_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Next!");
        }
    }
}
