using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftAutoServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serverName_TextChanged(object sender, EventArgs e)
        {

        }

        // FOCUSSED TEXTBOX TEMPORARY CODE TO ERASE TEMP FILLING
        private void TextBox_Focus(object sender, RoutedEventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }


        }

        private void importConfig_Click(object sender, EventArgs e)
        {

        }

        private void importMods_Click(object sender, EventArgs e)
        {

        }

        private void minRam_TextChanged(object sender, EventArgs e)
        {

        }
    }
