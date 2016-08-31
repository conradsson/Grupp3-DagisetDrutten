using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp3___Förskolan_Drutten
{
    public partial class StartForalder : Form
    {
        public StartForalder()
        {
            InitializeComponent();

            //  .Visable Effekter
            informationTabControl.Visible = true; 
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
        }

        private void loggaBox_Click(object sender, EventArgs e)
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
        }

        private void LoggaUtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            /*
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //...
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
            */

           // MessageBox.Show("Är du säker på att du vill logga ut?".)
        }
    }
}
