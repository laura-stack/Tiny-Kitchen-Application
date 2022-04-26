using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
        string add = "Add to Recipes";
        string end = "Cancel Search";
        bool continueS = true;
        bool saveR = false;
        APIrecipe search = new APIrecipe();
        public CustomDialog(string message, string list, string link, string picLink, string cal)
        {
            
            button1.Text = add;
            button2.Text = end;
            label1.Text = message;
            textBox1.Text = list;
            textBox3.Text = link;
            pictureBox2.ImageLocation=picLink;
            calCount.Text = cal;
            continueS = true;
            saveR = false;

        }

        public void SetBox(string message, string list, string link, string picLink, string cal)
        {
            this.button1.Text = add;
            this.button2.Text = end;
            this.label1.Text = message;
            this.textBox1.Text = list;
            this.textBox3.Text = link;
            calCount.Text = cal;
            this.pictureBox2.LoadAsync(picLink);

        }

        public bool GetContinue()
        {
            return this.continueS;
        }
        
        public void SetContinue(bool tf)
        {
            this.continueS = tf;
        }

        public bool GetSave()
        {
            
            return this.saveR;
        }
        private void addToRecipies_Click(object sender, EventArgs e)
        {
            this.saveR = true;
            System.Windows.MessageBox.Show("Saved!"); 
        }
       
        private void cancel_Click(object sender, EventArgs e)
        {
            const string message =
                "Are you sure that you would like to end your search?";
            const string caption = "Stop Searching";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else if (result == DialogResult.Yes)
            {
                this.continueS=false;
                this.Close();
            }

        }
    }
}