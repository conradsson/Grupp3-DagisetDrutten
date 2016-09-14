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
        Person AktuellPerson = new Person();
        Postgres p = new Postgres();

        public StartPersonal(Person aktuellperson)
        {
            InitializeComponent();
            //  Start Effekter..
            informationTabControl.Visible = true;

            AktuellPerson = aktuellperson;

            inloggadesAnvändarnamn.Text = aktuellperson.Användarnamn;

            p.HämtaInlägg();
            listBoxInlägg.DisplayMember = "InläggDisplay";
            //listBoxInlägg.DataSource = p.inläggslista;
            
        }
        
        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            p.HämtaInlägg();
            listBoxInlägg.DisplayMember = "InläggDisplay";
            //listBoxInlägg.DataSource = p.inläggslista;

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
            textBoxFörnamnMittkonto.Text = AktuellPerson.Förnamn;
            textBoxEfternamnMittkonto.Text = AktuellPerson.Efternamn;
            textBoxTelefonnrMittkonto.Text = AktuellPerson.Telefonnr;

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

            //dataGridAllaBarn.DataSource = null;
            Postgres p = new Postgres();

            barnAvdl2ListBox.DataSource = p.HämtanBarn();
            labelAntalBarn.Text = barnAvdl2ListBox.Items.Count.ToString();
            //dataGridAllaBarn.DataSource = p.HämtanBarn();

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
            p.HämtaInlägg();

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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NärvarandeRadioButton.Checked)
            {
                label15.Text = "Närvarande:";
                dataGridView1.DataSource = null;
                Postgres p = new Postgres();
                dataGridView1.DataSource = p.HämtaNärvaro(monthCalendar2.SelectionStart);
                label16.Text = dataGridView1.RowCount.ToString() + " Barn";
                label18.Text = "Skriv ut dagens närvarolista";


            }
            else if (FrånvarandeRadioButton.Checked)
            {
                label15.Text = "Frånvarande:";
                dataGridView1.DataSource = null;
                Postgres p = new Postgres();
                dataGridView1.DataSource = p.HämtaFrånvaro(monthCalendar2.SelectionStart);
                label16.Text = dataGridView1.RowCount.ToString() + " Barn";
                label18.Text = "Skriv ut dagens frånvarolista";

            } 
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {


            //frånvarandeListBox.DataSource = null;
            //frånvarandeListBox.DataSource = p.HämtaNärvaro(monthCalendar2.SelectionStart);


        }

        private void nyttInläggButton_Click(object sender, EventArgs e)
        {
            richTextBoxNyttInlägg.Clear();
            nyttInläggPanel.Visible = true;

        }

        private void avbrytButton_Click(object sender, EventArgs e)
        {
            // METOD FÖR ATT TA BORT SELECTED INLÄGG (DROP)
            richTextBoxNyttInlägg.Clear();
            nyttInläggPanel.Visible = false;
        }

        private void publiceraButton_Click(object sender, EventArgs e)
        {
            p.HämtaInlägg();
            //METOD FÖR ATT PUBLICERA INLÄGG (INSERT)
        }

        private void redigeraButton_Click(object sender, EventArgs e)
        {
            // METOD FÖR ATT REDIGERA SELECTED INLÄGG (UPDATE)
        }

        private void barnAvdl2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres(); 
            Barn AktuelltBarn = (Barn)barnAvdl2ListBox.SelectedItem;

            if (AktuelltBarn != null)
            {

                listBox1.DataSource = null;
                listBox1.DisplayMember = "VisaFörälder";
                listBox1.DataSource = p.HämtaBarnsFörälder(AktuelltBarn.Barnid);

                barnOverigtrichTextBox.Text = AktuelltBarn.Allergier + "\n" + AktuelltBarn.Annat;

               
            }
        }

        private void checkBoxAvdelning1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
             if (checkBoxAvdelning1.Checked == true && checkBoxAvdelning2.Checked == true)
            {
                Postgres p = new Postgres();
                listBox1.DataSource = null;
                //barnAvdl2ListBox.DataSource = p.HämtanBarn();
                barnAvdl2ListBox.DataSource = p.HämtaBarnEfterSök(textBoxSökRuta.Text);
                labelAntalBarn.Text = barnAvdl2ListBox.Items.Count.ToString();

            }

            else if (checkBoxAvdelning1.Checked == true)
            {
                Postgres p = new Postgres();
                listBox1.DataSource = null;
                //barnAvdl2ListBox.DataSource = p.HämtaBarnAvdelning1();
                barnAvdl2ListBox.DataSource = p.HämtaBarnEfterSök1(textBoxSökRuta.Text);
                labelAntalBarn.Text = barnAvdl2ListBox.Items.Count.ToString();
            }
            else if (checkBoxAvdelning2.Checked == true)
            {
                Postgres p = new Postgres();
                listBox1.DataSource = null;
                //barnAvdl2ListBox.DataSource = p.HämtaBarnAvdelning2();
                barnAvdl2ListBox.DataSource = p.HämtaBarnEfterSök2(textBoxSökRuta.Text);
                labelAntalBarn.Text = barnAvdl2ListBox.Items.Count.ToString();
            }
            else
            {
                Postgres p = new Postgres();
                listBox1.DataSource = null;
                //barnAvdl2ListBox.DataSource = p.HämtanBarn();
                barnAvdl2ListBox.DataSource = p.HämtaBarnEfterSök(textBoxSökRuta.Text);
                labelAntalBarn.Text = barnAvdl2ListBox.Items.Count.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSökRuta_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            klocklabel2.Text = DateTime.Now.ToLongTimeString().ToString();
            klocklabel1.Text = DateTime.Now.ToLongDateString().ToString();

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
