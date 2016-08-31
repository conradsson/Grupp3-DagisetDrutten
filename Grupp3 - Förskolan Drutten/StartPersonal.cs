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
    public partial class StartPersonal : Form
    {
        public StartPersonal()
        {
            InitializeComponent();
            //  Start Effekter
            informationTabControl.Visible = true;
        }


        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
        }

        private void mittKontoButton_Click(object sender, EventArgs e)// Mitt Konto-knappen
        {
            //  .Visable Effekter
            informationTabControl.Visible = false;
            MittKontoTabControl.Visible = true;
        }

        private void loggaBox_Click(object sender, EventArgs e)
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
