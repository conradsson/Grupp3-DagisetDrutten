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
        Person AktuellPerson = new Person();
        Postgres p = new Postgres();

        public StartForalder(Person aktuellperson)
        {
            InitializeComponent();
            //  Start Effekter.
            informationTabControl.Visible = true;

            AktuellPerson = aktuellperson;

            listBoxInlägg.ClearSelected();
            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggFörälder();

            inloggadesAnvändarnamn.Text = aktuellperson.Förnamn + " " + aktuellperson.Efternamn;

            //tiderBarnListBox.ClearSelected();
        }


        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            Postgres p = new Postgres();

            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggFörälder();
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
            Postgres p = new Postgres();


            textBoxFörnamnMittKonto.Text = AktuellPerson.Förnamn;
            textBoxEfternamnMittKonto.Text = AktuellPerson.Efternamn;
            textBoxTelefonnummerMittKonto.Text = AktuellPerson.Telefonnr;


            List<Barn> barnlista = new List<Barn>();
            barnlista = p.HämtaAktuellaBarn(AktuellPerson.Personid);
            listAktuellaBarn.DataSource = null;
            listAktuellaBarn.DataSource = barnlista;
            listAktuellaBarn.ClearSelected();
            textBoxFornamn.Clear();
            textBoxEfternamn.Clear();
            textBoxAllergier.Clear();
            richTextBoxAnnat.Clear();

            //  .Visable Effekter
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            TidertabControl.Visible = false;
            // NärvarotabControl.Visible = false;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;

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
            
            barnlista = p.HämtaFöräldersBarn(AktuellPerson.Personid);
            tiderBarnListBox.DataSource = null;
            
            tiderBarnListBox.DataSource = barnlista;
            //tiderBarnListBox.ClearSelected();
            listBoxMeddelaHämtning.DataSource = null;
            listBoxMeddelaHämtning.DataSource = barnlista;
            listBoxMeddelaFrånvaro.DataSource = null;
            listBoxMeddelaFrånvaro.DataSource = barnlista;

            groupBox2.Visible = false;
            groupBox3.Visible = false;

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
            Postgres p = new Postgres();


            textBoxFörnamnMittKonto.Text = AktuellPerson.Förnamn;
            textBoxEfternamnMittKonto.Text = AktuellPerson.Efternamn;
            textBoxTelefonnummerMittKonto.Text = AktuellPerson.Telefonnr;


            List<Barn> barnlista = new List<Barn>();
            barnlista = p.HämtaAktuellaBarn(AktuellPerson.Personid);
            listAktuellaBarn.DataSource = null;
            listAktuellaBarn.DataSource = barnlista;
            listAktuellaBarn.ClearSelected();
            textBoxFornamn.Clear();
            textBoxEfternamn.Clear();
            textBoxAllergier.Clear();
            richTextBoxAnnat.Clear();
            //  .Visable Effekter
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            TidertabControl.Visible = false;
            // NärvarotabControl.Visible = false;
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenLängre;
        }

        private void inloggadButton_MouseDown(object sender, MouseEventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenPushedLängre;

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
            string lämnas = comboBoxFrån1.Text + ":" + comboBoxFrån2.Text;
            string hämtas = comboBoxTill1.Text + ":" + comboBoxTill2.Text;

            if (lämnas == ":" && hämtas == ":")
            {

                MessageBox.Show("Var vänlig och fyll i tider.");
            }
            else
            {
                Postgres p = new Postgres();
                p.LäggTillTid(datum, barnid, lämnas, hämtas);

                Postgres pp = new Postgres();
                pp.KontrolleraFrånvaro(datum, barnid);
                Postgres p1 = new Postgres();
                dataGridViewHämtning.DataSource = null;
                dataGridViewHämtning.DataSource = p1.HämtaBarnetsTider(aktuelltbarn.Barnid);
                Postgres p2 = new Postgres();
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid);
                Postgres p3 = new Postgres();
                dataGridViewMeddelaFrånvaro.DataSource = null;
                dataGridViewMeddelaFrånvaro.DataSource = p3.HämtaBarnsFrånvaro(aktuelltbarn.Barnid);
                
            }

            comboBoxFrån1.Text = "";
            comboBoxFrån2.Text = "";
            comboBoxTill1.Text = "";
            comboBoxTill2.Text = "";
        }

        private void tiderBarnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
             

            if (aktuelltbarn != null)
            {
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p.HämtaBarnetsTider(aktuelltbarn.Barnid);
                //dataGridViewTiderBarn.Columns[1].Visible = false;
                //dataGridViewTiderBarn.Columns[2].Visible = false;

                Postgres po = new Postgres();
                string tid;
                DateTime datum = monthCalendar3.SelectionStart;
                tid = po.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);

                if (tid == "")
                {
                    comboBoxUppdateraTill1.Text = "";
                    comboBoxUppdateraTill2.Text = "";
                }
                else
                {
                    comboBoxUppdateraTill1.Text = tid[0].ToString() + tid[1].ToString();
                    comboBoxUppdateraTill2.Text = tid[3].ToString() + tid[4].ToString();
                }

                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);

                if (tidLämnas == "")
                {
                    comboBoxUppdateraFrån1.Text = "";
                    comboBoxUppdateraFrån2.Text = "";
                }
                else
                {
                    comboBoxUppdateraFrån1.Text = tidLämnas[0].ToString() + tidLämnas[1].ToString();
                    comboBoxUppdateraFrån2.Text = tidLämnas[3].ToString() + tidLämnas[4].ToString();
                }
                
                }
            //else
            //{
            //    MessageBox.Show("Välj ett barn i listan.");
            //}

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

                if (tid == "")
                {
                    groupBox3.Visible = false;
                    comboBoxUppdateraTill1.Text = "";
                    comboBoxUppdateraTill2.Text = "";
                }
                else
                {
                    groupBox3.Visible = true;
                    comboBoxUppdateraTill1.Text = tid[0].ToString() + tid[1].ToString();
                    comboBoxUppdateraTill2.Text = tid[3].ToString() + tid[4].ToString();
                }

                
                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);

                if (tid == "")
                {
                    groupBox2.Visible = true;
                    comboBoxUppdateraFrån1.Text = "";
                    comboBoxUppdateraFrån2.Text = "";
                }
                else
                {
                    groupBox2.Visible = false;
                    comboBoxUppdateraFrån1.Text = tidLämnas[0].ToString() + tidLämnas[1].ToString();
                    comboBoxUppdateraFrån2.Text = tidLämnas[3].ToString() + tidLämnas[4].ToString();
                }

            }
            //else
            //{
            //    MessageBox.Show("Välj ett barn i listan.");
            //}

        }

        private void listAktuellaBarn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn valdBarn = new Barn();
            valdBarn = (Barn)listAktuellaBarn.SelectedItem;

            if (valdBarn != null)
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
                string lamnas = comboBoxUppdateraFrån1.Text + ":" + comboBoxUppdateraFrån2.Text;
                string hamtas = comboBoxUppdateraTill1.Text + ":" + comboBoxUppdateraTill2.Text;

                if (lamnas == ":" && hamtas == ":")
                {
                    MessageBox.Show("Var vänlig och fyll i tider.");
                }
                else
                {
                    p.UppdateraTider(datum, id, lamnas, hamtas);
                    Postgres p1 = new Postgres();
                    dataGridViewHämtning.DataSource = null;
                    dataGridViewHämtning.DataSource = p1.HämtaBarnetsTider(aktuelltbarn.Barnid);
                    Postgres p2 = new Postgres();
                    dataGridViewTiderBarn.DataSource = null;
                    dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)listAktuellaBarn.SelectedItem;

            if (aktuelltbarn != null)
            {
                int id = aktuelltbarn.Barnid;
                string förnamn = textBoxFornamn.Text;
                string efternamn = textBoxEfternamn.Text;
                string allergier = textBoxAllergier.Text;
                string annat = richTextBoxAnnat.Text;
                p.UppdateraBarn(id, förnamn, efternamn, allergier, annat);
            }
            else
            {
                MessageBox.Show("Välj ett barn i listan.");
            }


            listAktuellaBarn.DataSource = null;
            List<Barn> barnlista = new List<Barn>();
            barnlista = p.HämtaAktuellaBarn(AktuellPerson.Personid);
            listAktuellaBarn.DataSource = barnlista;
            listAktuellaBarn.ClearSelected();
            textBoxFornamn.Clear();
            textBoxEfternamn.Clear();
            textBoxAllergier.Clear();
            richTextBoxAnnat.Clear();
        }

        private void buttonMeddelaHämtning_Click(object sender, EventArgs e)
        {
            {
                Barn aktuelltbarn = (Barn)listBoxMeddelaHämtning.SelectedItem;

                if (aktuelltbarn != null)
                {
                    int barnid = aktuelltbarn.Barnid;
                    string hamtas = textBoxMeddelaHämtning.Text;
                    //DateTime datum = monthCalendar1.SelectionStart;
                    DateTime datum;
                    Närvaro n = new Närvaro();

                    if (dataGridViewHämtning.SelectedRows != null)
                    {

                        n.Datum = Convert.ToDateTime(dataGridViewHämtning.SelectedCells[0].Value);
                        datum = n.Datum;

                        Postgres p = new Postgres();
                        p.KontrolleraHämtning(datum, barnid, hamtas);
                        //dataGridViewHämtning.ClearSelection();
                        textBoxMeddelaHämtning.Clear();
                    }


                    //p.MeddelaHämtning(barnid, hamtas, datum);
                    Postgres p1 = new Postgres();
                    dataGridViewHämtning.DataSource = null;
                    dataGridViewHämtning.DataSource = p1.HämtaBarnetsTider(aktuelltbarn.Barnid);
                    Postgres p2 = new Postgres();
                    dataGridViewTiderBarn.DataSource = null;
                    dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid);

                }
            }

        }

        private void listBoxMeddelaHämtning_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barn aktuelltb = new Barn();
            aktuelltb = (Barn)listBoxMeddelaHämtning.SelectedItem;

            if (aktuelltb != null)
            {
                //Postgres p = new Postgres();
                //string tid;
                //DateTime datum = monthCalendar1.SelectionStart;
                //tid = p.BarnetHämtasAv(aktuelltb.Barnid, datum);
                //textBoxMeddelaHämtning.Text = tid;

                Postgres p1 = new Postgres();
                dataGridViewHämtning.DataSource = null;
                dataGridViewHämtning.DataSource = p1.HämtaBarnetsTider(aktuelltb.Barnid);
            }
            //else
            //{
            //    MessageBox.Show("Välj ett barn i listan.");
            //}
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void uppdateraFörälder_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            //Person aktuellPerson = new Person();

            int id = AktuellPerson.Personid;
            string förnamn = textBoxFörnamnMittKonto.Text;
            string efternamn = textBoxEfternamnMittKonto.Text;
            string telefonnummer = textBoxTelefonnummerMittKonto.Text;

            p.UppdateraPerson(id, förnamn, efternamn, telefonnummer);
        }

        private void uppdateraförälder_Click_1(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            //Person aktuellPerson = new Person();

            int id = AktuellPerson.Personid;
            string förnamn = textBoxFörnamnMittKonto.Text;
            string efternamn = textBoxEfternamnMittKonto.Text;
            string telefonnummer = textBoxTelefonnummerMittKonto.Text;

            p.UppdateraPerson(id, förnamn, efternamn, telefonnummer);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)listBoxMeddelaFrånvaro.SelectedItem;

            if (aktuelltbarn != null)
            {
                Postgres p = new Postgres();
                int id = aktuelltbarn.Barnid;
                DateTime datum = monthCalendar2.SelectionStart;
                bool sjuk;
                bool ledig;

                if (radioButtonSjuk.Checked)
                {
                    sjuk = true;
                    ledig = false;
                    p.LäggTillFånvaro(datum, id, sjuk, ledig);
                    Postgres p1 = new Postgres();
                    p1.KontrolleraNärvaro(datum, id);

                    Postgres pp = new Postgres();
                    dataGridViewMeddelaFrånvaro.DataSource = null;
                    dataGridViewMeddelaFrånvaro.DataSource = pp.HämtaBarnsFrånvaro(id);

                }
                else if (radioButtonLedig.Checked)
                {
                    sjuk = false;
                    ledig = true;
                    p.LäggTillFånvaro(datum, id, sjuk, ledig);
                    Postgres p2 = new Postgres();
                    p2.KontrolleraNärvaro(datum, id);

                    Postgres pp = new Postgres();
                    dataGridViewMeddelaFrånvaro.DataSource = null;
                    dataGridViewMeddelaFrånvaro.DataSource = pp.HämtaBarnsFrånvaro(id);
                }
                else 
                {
                    sjuk = false;
                    ledig = false;
                    MessageBox.Show("För att registrera frånvaro måste du välja antingen sjuk eller ledig.");
                }
                
            }
        }

        private void uppdateraförälder_Click_2(object sender, EventArgs e)
        {
            Postgres p = new Postgres();

            int id = AktuellPerson.Personid;
            string förnamn = textBoxFörnamnMittKonto.Text;
            string efternamn = textBoxEfternamnMittKonto.Text;
            string telefonnummer = textBoxTelefonnummerMittKonto.Text;
            
            p.UppdateraPerson(id, förnamn, efternamn, telefonnummer);

            AktuellPerson.Förnamn =    textBoxFörnamnMittKonto.Text;
            AktuellPerson.Efternamn=    textBoxEfternamnMittKonto.Text;
            AktuellPerson.Telefonnr=    textBoxTelefonnummerMittKonto.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            klocklabel2.Text = DateTime.Now.ToLongTimeString().ToString();
            klocklabel1.Text = DateTime.Now.ToLongDateString().ToString();

        }

        private void listBoxInlägg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Information AktuelltInlägg = (Information)listBoxInlägg.SelectedItem;

            if (AktuelltInlägg != null)
            {

                textBoxDatum.Text = AktuelltInlägg.Datum;
                textBoxRubrik.Text = AktuelltInlägg.InläggsRubrik;
                richTextBoxPubliceradeInlägg.Text = AktuelltInlägg.InläggsText;

                textBoxSkrivetAv.Text = AktuelltInlägg.SkrivetAv;
            }
        }

        private void ändraLösenordButton_Click(object sender, EventArgs e)
        {
            textBoxNuvarandeLösen.Clear();
            textBoxNyttLösen.Clear();
            textBoxNyttLösen2.Clear();
            ändraLösenPanel.Visible = true;
        }

        private void ändraLösenAvbryt_Click(object sender, EventArgs e)
        {
            ändraLösenPanel.Visible = false;
        }

        private void ändralösenBekräfta_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();

            int id = AktuellPerson.Personid;
            string nuvarandeLösenord = textBoxNuvarandeLösen.Text;
            string nyttLösenord = textBoxNyttLösen.Text;
            string nyttLösenord2 = textBoxNyttLösen2.Text;

            if (p.LösenordsEncrypt(nuvarandeLösenord) == AktuellPerson.Lösenord)
            {
                if (textBoxNyttLösen.Text == textBoxNyttLösen2.Text)
                {
                    int antaltecken = textBoxNyttLösen.Text.Count();
                    if (antaltecken >= 4)
                    {
                        p.ÄndraLösenord(id, nuvarandeLösenord, nyttLösenord);
                        ändraLösenPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Det nya lösenordet måste minsta vara 4 st tecken.");
                    }

                }
                else
                {
                    MessageBox.Show("Det nya lösenordet var inte lika.");
                }
            }
            else
            {
                MessageBox.Show("Det nuvarande lösenordet var fel.");
            }
        }

        private void listBoxMeddelaFrånvaro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barn aktuelltbarn = (Barn)listBoxMeddelaFrånvaro.SelectedItem;
            
            
            if (aktuelltbarn != null)
            {
                Postgres p = new Postgres();
                int barnid = aktuelltbarn.Barnid;
                dataGridViewMeddelaFrånvaro.DataSource = null;
                dataGridViewMeddelaFrånvaro.DataSource = p.HämtaBarnsFrånvaro(barnid);
            }
        }
    }
}
