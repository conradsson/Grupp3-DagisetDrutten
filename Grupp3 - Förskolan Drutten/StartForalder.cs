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
        DateTime idag = DateTime.Today;


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

            informationButton.BackgroundImage = Properties.Resources.informationButtonHär;
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
            informationButton.BackgroundImage = Properties.Resources.informationButtonHär;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
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
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonHär;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;

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
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonHär;

            List<Barn> barnlista = new List<Barn>();
            
            Postgres p = new Postgres();
            
            barnlista = p.HämtaFöräldersBarn(AktuellPerson.Personid);
            tiderBarnListBox.DataSource = null;
            
            tiderBarnListBox.DataSource = barnlista;
            //tiderBarnListBox.ClearSelected();
            listBoxMeddelaFrånvaro.DataSource = null;
            listBoxMeddelaFrånvaro.DataSource = barnlista;

            groupBox2.Visible = false;
            groupBox3.Visible = false;

            HämtaVilkenGroupboxSomSkasynas(idag);

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
            Postgres p = new Postgres();

            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggFörälder();
            //  .Visable Effekter
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            TidertabControl.Visible = false;
            informationButton.BackgroundImage = Properties.Resources.informationButtonHär;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
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
            DateTime datummetod = DateTime.Today;
            int barnid = aktuelltbarn.Barnid;
            string lämnas = comboBoxFrån1.Text + ":" + comboBoxFrån2.Text;
            string hämtas = comboBoxTill1.Text + ":" + comboBoxTill2.Text;
            DateTime dagensDatum = DateTime.Today;
            string hamtas = textBoxHämtasAv1.Text;
            
            if (datum < dagensDatum)
            {
                MessageBox.Show("Du kan tyvärr inte lägga in tider som är före dagens datum. \nVänligen välj ett annat datum.");
            }
            else if (lämnas == ":" && hämtas == ":")
            {
                MessageBox.Show("Var vänlig och fyll i tider.");
            }
            else if(hämtas == "18:05" || hämtas == "18:10" || hämtas == "18:15" || hämtas == "18:20" || hämtas == "18:25" || hämtas == "18:30" || hämtas == "18:35" || hämtas == "18:40" || hämtas == "18:45" || hämtas == "18:50" || hämtas == "18:55")
            {
                MessageBox.Show("Tiden som barnet hämtas får ej anges till senare än kl 18:00.");
            }
            else
            {

                    textBoxHämtasAv1.Clear();
                
                Postgres pp = new Postgres();
                bool frånvaro = pp.KontrolleraFrånvaro(datum, barnid);
                
                if (frånvaro == true)
                {
                    DialogResult result = MessageBox.Show("Det finns en frånvaro meddelad detta datum! \n\nOm du trycker på OK meddelas tiden och frånvaron tas bort. \nOm du trycker på AVBRYT meddelas inte tiden och frånvaron kvarstår.", "Meddela tid", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        //this.Close();
                        Postgres p = new Postgres();
                        p.LäggTillTid(datum, barnid, lämnas, hämtas);

                        Postgres po = new Postgres();
                    po.KontrolleraHämtning(datum, barnid, hamtas);

                    Postgres p4 = new Postgres();
                    p4.TaBortFrånvaro(datum, barnid);
                    }
                  
                }
                else
                    {
                        Postgres p = new Postgres();
                        p.LäggTillTid(datum, barnid, lämnas, hämtas);

                        Postgres po = new Postgres();
                        po.KontrolleraHämtning(datum, barnid, hamtas);
                    }
                Postgres p1 = new Postgres();
                Postgres p2 = new Postgres();
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid, datummetod);
                Postgres p3 = new Postgres();
                dataGridViewMeddelaFrånvaro.DataSource = null;
                dataGridViewMeddelaFrånvaro.DataSource = p3.HämtaBarnsFrånvaro(aktuelltbarn.Barnid, datummetod);
               
            }

            comboBoxFrån1.Text = "";
            comboBoxFrån2.Text = "";
            comboBoxTill1.Text = "";
            comboBoxTill2.Text = "";
            MetodHämtaBarnetsTid(datum);
        }

        private void tiderBarnListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            DateTime datum = monthCalendar3.SelectionStart;
             

            if (aktuelltbarn != null)
            {
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p.HämtaBarnetsTider(aktuelltbarn.Barnid, idag);
               
                MetodHämtaBarnetsTid(datum);
                
                }

        }
        

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Barn aktuelltbarn = new Barn();

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
        private void HämtaVilkenGroupboxSomSkasynas(DateTime datum)
        {
                  Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            textBoxHämtasAv1.Clear();
            if (aktuelltbarn != null)
            {

                Postgres p = new Postgres();
                string tid;
                
                tid = p.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);
                Postgres post = new Postgres();
                string hämtasAv = post.BarnetHämtasAv(aktuelltbarn.Barnid, datum);

                if (tid.Contains("Co"))
                {
                    MessageBox.Show("Tiden kan inte hämtas.");
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
                else if (tid == "")
                {
                    groupBox3.Visible = false;
                    comboBoxUppdateraTill1.Text = "";
                    comboBoxUppdateraTill2.Text = "";
                    button5.Visible = false;
                    button2.Visible = true;
                }

                else
                {
                    groupBox3.Visible = true;
                    button5.Visible = true;
                    button2.Visible = false;
                    comboBoxUppdateraTill1.Text = tid[0].ToString() + tid[1].ToString();
                    comboBoxUppdateraTill2.Text = tid[3].ToString() + tid[4].ToString();
                    textBoxHämtasAv1.Text = hämtasAv;
                }


                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);

                if (tidLämnas.Contains("Co"))
                {
                    MessageBox.Show("Tiden kan inte hämtas.");
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
                else if (tid == "")
                {
                    groupBox2.Visible = true;
                    comboBoxUppdateraFrån1.Text = "";
                    comboBoxUppdateraFrån2.Text = "";
                    button5.Visible = false;
                    button2.Visible = true;
                }
                else
                {
                    groupBox2.Visible = false;
                    button5.Visible = true;
                    button2.Visible = false;
                    comboBoxUppdateraFrån1.Text = tidLämnas[0].ToString() + tidLämnas[1].ToString();
                    comboBoxUppdateraFrån2.Text = tidLämnas[3].ToString() + tidLämnas[4].ToString();
                    textBoxHämtasAv1.Text = hämtasAv;
                }
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
                DateTime datummetod = DateTime.Today;
                string lamnas = comboBoxUppdateraFrån1.Text + ":" + comboBoxUppdateraFrån2.Text;
                string hamtas = comboBoxUppdateraTill1.Text + ":" + comboBoxUppdateraTill2.Text;
                string hamtasAv = textBoxHämtasAv1.Text;

                if (lamnas == ":" && hamtas == ":")
                {
                    MessageBox.Show("Var vänlig och fyll i tider.");
                }
                else if (hamtas == "18:05" || hamtas == "18:10" || hamtas == "18:15" || hamtas == "18:20" || hamtas == "18:25" || hamtas == "18:30" || hamtas == "18:35" || hamtas == "18:40" || hamtas == "18:45" || hamtas == "18:50" || hamtas == "18:55")
                {
                    MessageBox.Show("Tiden som barnet hämtas får ej anges till senare än kl 18:00.");
                }
                else
                {
                    p.UppdateraTider(datum, id, lamnas, hamtas, hamtasAv);
                    Postgres p1 = new Postgres();
                    Postgres p2 = new Postgres();
                    dataGridViewTiderBarn.DataSource = null;
                    dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid, datummetod);
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
                DateTime datummetod = DateTime.Today;
                bool sjuk;
                bool ledig;
                bool närvaro;

                if (datum < datummetod)
                {
                    MessageBox.Show("Du kan tyvärr inte meddela frånvaro för en dag som är före dagens datum. \nVänligen välj ett annat datum.");
                }
                else if (radioButtonSjuk.Checked)
                {
                    sjuk = true;
                    ledig = false;
                    
                    Postgres p1 = new Postgres();
                    närvaro = p1.KontrolleraNärvaro(datum, id);
                    if (närvaro == true)
                    {
                        DialogResult result = MessageBox.Show("Det finns en tid meddelad detta datum! \n\nOm du trycker på OK meddelas frånvaron och tiden tas bort. \nOm du trycker på AVBRYT meddelas inte frånvaron och tiden kvarstår.", "Meddela frånvaro", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            p.LäggTillFånvaro(datum, id, sjuk, ledig);

                            Postgres post = new Postgres();
                            post.TaBortNärvaro(datum, id);
                        }
                       
                    }
                    else
                    {   
                        Postgres p2 = new Postgres();
                        p2.LäggTillFånvaro(datum, id, sjuk, ledig);
                    }

                }
                else if (radioButtonLedig.Checked)
                {
                    sjuk = false;
                    ledig = true;
                    Postgres p1 = new Postgres();
                    närvaro = p1.KontrolleraNärvaro(datum, id);
                    if (närvaro == true)
                    {
                        DialogResult result = MessageBox.Show("Det finns en tid meddelad detta datum! \n\nOm du trycker på OK meddelas frånvaron och tiden tas bort. \nOm du trycker på AVBRYT meddelas inte frånvaron och tiden kvarstår.", "Meddela frånvaro", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            p.LäggTillFånvaro(datum, id, sjuk, ledig);

                            Postgres post = new Postgres();
                            post.TaBortNärvaro(datum, id);
                        }

                    }
                    else
                    {
                        Postgres p2 = new Postgres();
                        p2.LäggTillFånvaro(datum, id, sjuk, ledig);
                    }
             
                }
                else 
                {
                    sjuk = false;
                    ledig = false;
                    MessageBox.Show("För att registrera frånvaro måste du välja antingen sjuk eller ledig.");
                }
                Postgres pp = new Postgres();
                    dataGridViewMeddelaFrånvaro.DataSource = null;
                    dataGridViewMeddelaFrånvaro.DataSource = pp.HämtaBarnsFrånvaro(id, datum);
                    Postgres p3 = new Postgres();
                    Postgres p4 = new Postgres();
                    dataGridViewTiderBarn.DataSource = null;
                    dataGridViewTiderBarn.DataSource = p4.HämtaBarnetsTider(id, datum);
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
            ändraLösenPanel.Location = new Point(33, 37);
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
            DateTime datummetod = DateTime.Today;
            
            if (aktuelltbarn != null)
            {
                Postgres p = new Postgres();
                int barnid = aktuelltbarn.Barnid;
                dataGridViewMeddelaFrånvaro.DataSource = null;
                dataGridViewMeddelaFrånvaro.DataSource = p.HämtaBarnsFrånvaro(barnid, datummetod);
            }
        }

        private void MetodHämtaBarnetsTid(DateTime datum)
        {
            Barn aktuelltbarn = new Barn();
            aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            textBoxHämtasAv1.Clear();
            if (aktuelltbarn != null)
            {

                Postgres p = new Postgres();
                string tid;
                
                tid = p.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);
                Postgres post = new Postgres();
                string hämtasAv = post.BarnetHämtasAv(aktuelltbarn.Barnid, datum);

                if (tid.Contains("Co"))
                {
                    MessageBox.Show("Tiden kan inte hämtas.");
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
                else if (tid == "")
                {
                    groupBox3.Visible = false;
                    comboBoxUppdateraTill1.Text = "";
                    comboBoxUppdateraTill2.Text = "";
                    button5.Visible = false;
                    button2.Visible = true;
                }

                else
                {
                    groupBox3.Visible = true;
                    button5.Visible = true;
                    button2.Visible = false;
                    comboBoxUppdateraTill1.Text = tid[0].ToString() + tid[1].ToString();
                    comboBoxUppdateraTill2.Text = tid[3].ToString() + tid[4].ToString();
                    textBoxHämtasAv1.Text = hämtasAv;
                }


                Postgres p2 = new Postgres();
                string tidLämnas;
                tidLämnas = p2.BarnetsLämnaTid(aktuelltbarn.Barnid, datum);

                if (tidLämnas.Contains("Co"))
                {
                    MessageBox.Show("Tiden kan inte hämtas.");
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;
                }
                else if (tid == "")
                {
                    groupBox2.Visible = true;
                    comboBoxUppdateraFrån1.Text = "";
                    comboBoxUppdateraFrån2.Text = "";
                    button5.Visible = false;
                    button2.Visible = true;
                }
                else
                {
                    groupBox2.Visible = false;
                    button5.Visible = true;
                    button2.Visible = false;
                    comboBoxUppdateraFrån1.Text = tidLämnas[0].ToString() + tidLämnas[1].ToString();
                    comboBoxUppdateraFrån2.Text = tidLämnas[3].ToString() + tidLämnas[4].ToString();
                    textBoxHämtasAv1.Text = hämtasAv;
                }

            }

        }

        private void monthCalendar3_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime datum = monthCalendar3.SelectionStart;
            MetodHämtaBarnetsTid(datum);
     
        }

        private void buttonMeddelaHämtning_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxMeddelaHämtning_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonHjälpSenaste_MouseHover(object sender, EventArgs e)
        {
            panelHjälpSenaste.Visible = true;
            labelHjälpSenaste.Visible = true;
        }

        private void buttonHjälpSenaste_MouseLeave(object sender, EventArgs e)
        {
            panelHjälpSenaste.Visible = false;
            labelHjälpSenaste.Visible = false;
        }

        private void buttonHjälpKontoUppgifter_MouseHover(object sender, EventArgs e)
        {
            panelHjälpKontoUppgifter.Visible = true;
            labelHjälpKontoUppgifter.Visible = true;
        }

        private void buttonHjälpKontoUppgifter_MouseLeave(object sender, EventArgs e)
        {
            panelHjälpKontoUppgifter.Visible = false;
            labelHjälpKontoUppgifter.Visible = false;
        }

        private void buttonHjälpMinaBarn_MouseHover(object sender, EventArgs e)
        {
            panelHjälpMinaBarn.Visible = true;
            labelHjälpMinaBarn.Visible = true;  
        }

        private void buttonHjälpMinaBarn_MouseLeave(object sender, EventArgs e)
        {
            panelHjälpMinaBarn.Visible = false;
            labelHjälpMinaBarn.Visible = false;
        }

        private void buttonHjälpMeddelaTider_MouseHover(object sender, EventArgs e)
        {
            panelHjälpMeddelaTider.Visible = true;
            labelHjälpMeddelaTider.Visible = true;
        }

        private void buttonHjälpMeddelaTider_MouseLeave(object sender, EventArgs e)
        {
            panelHjälpMeddelaTider.Visible = false;
            labelHjälpMeddelaTider.Visible = false;
        }

        private void buttonHjälpMeddelaFrånvaro_MouseHover(object sender, EventArgs e)
        {
            panelHjälpMeddelaFrånvaro.Visible = true;
            labelHjälpMeddelaFrånvaro.Visible = true;
        }

        private void buttonHjälpMeddelaFrånvaro_MouseLeave(object sender, EventArgs e)
        {
            panelHjälpMeddelaFrånvaro.Visible = false;
            labelHjälpMeddelaFrånvaro.Visible = false;
        }
    }
}
