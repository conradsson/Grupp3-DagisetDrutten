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
            //  Start Effekter.
            informationTabControl.Visible = true; 
        }


        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            TidertabControl.Visible = false;
            //NärvarotabControl.Visible = false;
            informationButton.BackgroundImage = Properties.Resources.ButtonDrutten2;
        }
        private void informationButton_MouseDown(object sender, MouseEventArgs e)
        {
            informationButton.BackgroundImage = Properties.Resources.ButtonDruttenPushed1;
        }

        private void mittKontoButton_Click(object sender, EventArgs e)// Mitt Konto-knappen
        {
            //  .Visable Effekter
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            TidertabControl.Visible = false;
           // NärvarotabControl.Visible = false;
            mittKontoButton.BackgroundImage = Properties.Resources.ButtonDrutten2;
        }
        private void mittKontoButton_MouseDown(object sender, MouseEventArgs e)
        {
            mittKontoButton.BackgroundImage = Properties.Resources.ButtonDruttenPushed1;
        }

        private void tiderButton_Click(object sender, EventArgs e) // Tider-knappen
        {
            //  .Visable Effekter
            TidertabControl.Visible = true;
            //NärvarotabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            tiderButton.BackgroundImage = Properties.Resources.ButtonDrutten2;
        }
        private void tiderButton_MouseDown(object sender, MouseEventArgs e)
        {
            tiderButton.BackgroundImage = Properties.Resources.ButtonDruttenPushed1;
        }

        private void närvaroButton_Click(object sender, EventArgs e) // Närvaro-knappen
        {
            //  .Visable Effekter
           // NärvarotabControl.Visible = true;
            TidertabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            närvaroButton.BackgroundImage = Properties.Resources.ButtonDrutten2;
        }
        private void närvaroButton_MouseDown(object sender, MouseEventArgs e)
        {
            närvaroButton.BackgroundImage = Properties.Resources.ButtonDruttenPushed1;
        }
        
        private void loggaBox_Click(object sender, EventArgs e) // Drutten Loggan
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
        }

        private void LoggaUtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
            DialogResult result = MessageBox.Show("Är du säker på att du vill logga ut?", "Logga ut", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
                
            }
 
           
        }
    }
}
