using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        string add = "Add to Collection";
        string end = "Cancel Search";
        bool continueS = true;
        APIrecipe search = new APIrecipe();
        public CustomDialog(string message, string list, string link, string picLink)
        {
            
            button1.Text = add;
            button2.Text = end;
            label1.Text = message;
            textBox1.Text = list;
            linkLabel1.Text = link;
            pictureBox2.ImageLocation=picLink;
            continueS = true;

        }

        public void SetBox(string message, string list, string link, string picLink)
        {
            this.button1.Text = add;
            this.button2.Text = end;
            this.label1.Text = message;
            this.textBox1.Text = list;
            this.linkLabel1.Text = link;
            this.pictureBox2.LoadAsync(picLink);

        }

        public bool GetBox()
        {
            return this.continueS;
        }

        private void addToCollection_Click(object sender, EventArgs e)
        {
            //add to collection
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = linkLabel1.Text,
                UseShellExecute = true
            };
            Process.Start(psi);
            
        }
    }
}