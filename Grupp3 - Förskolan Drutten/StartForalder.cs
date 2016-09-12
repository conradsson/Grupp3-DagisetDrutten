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

            //List<Barn> barnlista = new List<Barn>();
            //Postgres p = new Postgres();
            //Login l = new Login();
            //barnlista = p.HämtaFöräldersBarn();
            //tiderBarnListBox.DataSource = null;
            //tiderBarnListBox.DataSource = barnlista;
            //listBoxMeddelaHämtning.DataSource = null;
            //listBoxMeddelaHämtning.DataSource = barnlista;
            //listBoxMeddelaFrånvaro.DataSource = null;
            //listBoxMeddelaFrånvaro.DataSource = barnlista;


            


        }
        //

        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            Postgres p = new Postgres();  
            Login l = new Login();

            p.HämtaInloggadAnvändare(l.inskrivetAnvändarnamn, l.inskrivetLösenord);  // Testar lösning på "aktuellPerson"
            MessageBox.Show(p.aktuellPerson.Användarnamn);


            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            TidertabControl.Visible = false;
            //NärvarotabControl.Visible = false;
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
            TidertabControl.Visible = false;
           // NärvarotabControl.Visible = false;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;


            Postgres p = new Postgres();
            //p.ReturneraVärdenAvAktuellperson(label19);

            List<Barn> barnlista = new List<Barn>();
           // barnlista = p.HämtaAktuellaBarn();
            listAktuellaBarn.DataSource = null;
            listAktuellaBarn.DataSource = barnlista;
            listAktuellaBarn.ClearSelected();


        }
        private void mittKontoButton_MouseDown(object sender, MouseEventArgs e)
        {
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonPushed;
        }

        private void tiderButton_Click(object sender, EventArgs e) // Tider-knappen
        {
            //  .Visable Effekter
            TidertabControl.Visible = true;
            //NärvarotabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;

            List<Barn> barnlista = new List<Barn>();
            Postgres p = new Postgres();
            //Login l = new Login();
            barnlista = p.HämtaFöräldersBarn();
            tiderBarnListBox.DataSource = null;
            tiderBarnListBox.DataSource = barnlista;
            listBoxMeddelaHämtning.DataSource = null;
            listBoxMeddelaHämtning.DataSource = barnlista;
            listBoxMeddelaFrånvaro.DataSource = null;
            listBoxMeddelaFrånvaro.DataSource = barnlista;
            
        }
        private void tiderButton_MouseDown(object sender, MouseEventArgs e)
        {
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDruttenPushed;
        }

        private void närvaroButton_Click(object sender, EventArgs e) // Närvaro-knappen
        {
            //  .Visable Effekter
           // NärvarotabControl.Visible = true;
            TidertabControl.Visible = false;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            närvaroButton.BackgroundImage = Properties.Resources.närvaroButtonDrutten;

    
        }
        private void närvaroButton_MouseDown(object sender, MouseEventArgs e)
        {
            närvaroButton.BackgroundImage = Properties.Resources.närvaroButtonDruttenPushed;
        }
        
        private void loggaBox_Click(object sender, EventArgs e) // Drutten Loggan
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
            TidertabControl.Visible = false;
            // NärvarotabControl.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Barn aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            DateTime datum = monthCalendar3.SelectionStart;
            int barnid = aktuelltbarn.Barnid;
            string hämtas = lämnasTextBox.Text;
            string lämnas = hämtasTextBox.Text;

            Postgres p = new Postgres();
            p.LäggTillTid(datum, barnid, hämtas, lämnas);
        }

        private void tiderBarnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            if (aktuelltbarn!= null)
            {
                Postgres p = new Postgres();
                string tid;
                DateTime datum = monthCalendar3.SelectionStart;
                tid = p.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);
                textBoxUppdateraTill.Text = tid;
            
                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);
                textBoxFrån.Text = tidLämnas;
            }
            else
            {
                MessageBox.Show("Välj ett barn i listan.");
            }
           
   

            
        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;

            if (aktuelltbarn != null)
            {
                Postgres p = new Postgres();
                string tid;
                DateTime datum = monthCalendar3.SelectionStart;
                tid = p.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);
                textBoxUppdateraTill.Text = tid;

                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);
                textBoxFrån.Text = tidLämnas;
            }
            else
            {
                MessageBox.Show("Välj ett barn i listan.");
            }
            
        }

        private void listAktuellaBarn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn valdBarn = new Barn();
            valdBarn = (Barn)listAktuellaBarn.SelectedItem;

                if(valdBarn != null)
                {
                textBoxFornamn.Text = valdBarn.Förnamn.ToString();
                textBoxEfternamn.Text = valdBarn.Efternamn.ToString();
                textBoxAllergier.Text = valdBarn.Allergier.ToString();
                richTextBoxAnnat.Text = valdBarn.Annat.ToString();

                listAktuellaBarn.DisplayMember = "visaBarn";
                
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;

            if (aktuelltbarn != null)
            {
                Postgres p = new Postgres();
                int id = aktuelltbarn.Barnid;
                DateTime datum = monthCalendar3.SelectionStart;
                string lamnas = textBoxFrån.Text;
                string hamtas = textBoxUppdateraTill.Text;
                p.UppdateraTider(datum, id, lamnas, hamtas);
            }
            
        }
    }
}
