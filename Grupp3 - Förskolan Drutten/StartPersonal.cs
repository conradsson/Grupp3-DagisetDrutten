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
            //  Start Effekter..
            informationTabControl.Visible = true;
        }

        public BindingList<Närvaro> närvarolista = new BindingList<Närvaro>();


        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            BarntabControl.Visible = false;
            NärvarotabControl.Visible = false;
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
        }
        private void informationButton_MouseDown(object sender, MouseEventArgs e)
        {
            informationButton.BackgroundImage = Properties.Resources.informationButtonDruttenPushed;
        }

        private void mittKontoButton_Click(object sender, EventArgs e)// Mitt Konto-knappen
        {
            //  .Visable Effekter
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            BarntabControl.Visible = false;
            NärvarotabControl.Visible = false;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;
        }
        private void mittKontoButton_MouseDown(object sender, MouseEventArgs e)
        {
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonPushed;
        }

        private void barnButton_Click(object sender, EventArgs e) // Barn-knappen
        {
            //  .Visable Effekter
            BarntabControl.Visible = true;
            NärvarotabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            barnButton.BackgroundImage = Properties.Resources.barnButtonDrutten;
        }
        private void barnButton_MouseDown(object sender, MouseEventArgs e)
        {
            barnButton.BackgroundImage = Properties.Resources.barnButtonDruttenPushed;
        }

        private void tiderButton_Click(object sender, EventArgs e) // Tider-knappen
        {
            barnButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
        }
        private void tiderButton_MouseDown(object sender, MouseEventArgs e)
        {
            barnButton.BackgroundImage = Properties.Resources.tiderButtonDruttenPushed;
        }

        private void närvaroButton_Click(object sender, EventArgs e) // Närvaro-knappen
        {
            //  .Visable Effekter
            NärvarotabControl.Visible = true;
            BarntabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            närvaroButton.BackgroundImage = Properties.Resources.närvaroButtonDrutten;
        }
        private void närvaroButton_MouseDown(object sender, MouseEventArgs e)
        {

            närvaroButton.BackgroundImage = Properties.Resources.närvaroButtonDruttenPushed;
        }

        private void loggaBox_Click(object sender, EventArgs e)// Drutten loggan
        {
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
        }


        private void loggaUtButton_Click(object sender, EventArgs e)
        {
            loggaUtButton.BackgroundImage = Properties.Resources.loggaUtButtonDrutten;

            DialogResult result = MessageBox.Show("Är du säker på att du vill logga ut?", "Logga ut", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }

        private void loggaUtButton_MouseDown(object sender, MouseEventArgs e)
        {
            loggaUtButton.BackgroundImage = Properties.Resources.loggaUtButtonDruttenPushed;
        }

        private void inloggadButton_Click(object sender, EventArgs e)
        {
            //  .Visable Effekter
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            BarntabControl.Visible = false;
            NärvarotabControl.Visible = false;
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDrutten;
        }

        private void inloggadButton_MouseDown(object sender, MouseEventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonPushed;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Är du säker på att du vill avsluta? ", "Avsluta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();


            MessageBox.Show(p.VisaNärvaro(monthCalendar2.SelectionStart.ToString());


        }
    }
}
