﻿using System;
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
            Postgres p1 = new Postgres();

            p1.UppdateraStatusPåInlogg(aktuellperson.Inloggad, aktuellperson.Personid);
            Login.ActiveForm.Hide();
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
                Postgres p = new Postgres();

                AktuellPerson.Inloggad = false;
                p.UppdateraStatusPåInlogg(AktuellPerson.Inloggad, AktuellPerson.Personid);
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
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonHär;
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
            inloggadesAnvändarnamn.BackColor = Color.WhiteSmoke;
        }

        private void inloggadButton_MouseDown(object sender, MouseEventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenPushedLängre;
            inloggadesAnvändarnamn.BackColor = Color.LightGray;

        }
        private void inloggadesAnvändarnamn_Click(object sender, EventArgs e)
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
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenLängre;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonHär;
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
            inloggadesAnvändarnamn.BackColor = Color.WhiteSmoke;
        }

        private void inloggadesAnvändarnamn_MouseDown(object sender, MouseEventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenPushedLängre;
            inloggadesAnvändarnamn.BackColor = Color.LightGray;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Är du säker på att du vill avsluta? ", "Avsluta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Postgres p = new Postgres();

                AktuellPerson.Inloggad = false;
                p.UppdateraStatusPåInlogg(AktuellPerson.Inloggad, AktuellPerson.Personid);
                Application.Exit();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barn aktuelltbarn = (Barn)tiderBarnListBox.SelectedItem;
            DateTime datum = monthCalendar3.SelectionStart;
            
            int barnid = aktuelltbarn.Barnid;
            string från1 = comboBoxFrån1.Text;
            string från2 = comboBoxFrån2.Text;
            string lämnas = från1 + ":" + från2;

            string till1 = comboBoxTill1.Text;
            string till2 = comboBoxTill2.Text;
            string hämtas = till1 + ":" + till2;
            
            string hamtas = textBoxHämtasAv1.Text;

            if (datum < idag)
            {
                MessageBox.Show("Du kan tyvärr inte lägga in tider som är före dagens datum. \nVänligen välj ett annat datum.");
            }
            else if (från1 == "" || från2 == "" || till1 == "" || till2 == "")
            {
                MessageBox.Show("Var vänlig kontrollera att Meddela tider är korrekt ifylld.\n\nIngen ruta där tider fylls i får lämnas tom.");
            }
            else if (från1 == "hh" || från2 == "mm" || till1 == "hh" || till2 == "mm")
            {
                MessageBox.Show("Var vänlig kontrollera att Meddela tider är korrekt ifylld.");
            }
            else if (hämtas == lämnas)
            {
                MessageBox.Show("Var vänlig kontrollera att Meddela tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte vara samma tid som barnet hämtas");
            }
            else if (lämnas == ":" && hämtas == ":")
            {
                MessageBox.Show("Var vänlig och fyll i tider.");
            }
            else if (Convert.ToInt32(från1) > Convert.ToInt32(till1))
            {
                MessageBox.Show("Var vänlig kontrollera att Meddela tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte anges till en senare tid än när barnet hämtas.");
            }
            else if (från1 == till1 && Convert.ToInt32(från2) > Convert.ToInt32(till2))
            {
                    MessageBox.Show("Var vänlig kontrollera att Meddela tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte anges till en senare tid än när barnet hämtas.");                
            }
            else if (hämtas == "18:05" || hämtas == "18:10" || hämtas == "18:15" || hämtas == "18:20" || hämtas == "18:25" || hämtas == "18:30" || hämtas == "18:35" || hämtas == "18:40" || hämtas == "18:45" || hämtas == "18:50" || hämtas == "18:55")
            {
                MessageBox.Show("Tiden som barnet hämtas får ej anges till senare än kl 18:00.");
            }
            else
            {
                textBoxHämtasAv1.Clear();

                DateTime start = monthCalendar3.SelectionStart;
                DateTime end = monthCalendar3.SelectionEnd;
                bool frånvaro = false;
                String datumet = "";
                for (int i = 0; i <= end.Subtract(start).Days; i++)
                {
                    Postgres pp = new Postgres();
                    datumet = start.AddDays(i).ToString("yyyy-MM-dd");
                
                    frånvaro = pp.KontrolleraFrånvaro(Convert.ToDateTime(datumet), barnid);
                    
                    if (frånvaro == true)
                    {
                        DialogResult result = MessageBox.Show("Det finns en frånvaro meddelad detta datum " +datumet+ "!" + " \n\nOm du trycker på OK meddelas tiden och frånvaron tas bort. \nOm du trycker på AVBRYT meddelas inte tiden och frånvaron kvarstår.", "Meddela tid", MessageBoxButtons.OKCancel);
                           if (result == DialogResult.OK)
                           {
                               Postgres p = new Postgres();
                               p.LäggTillTid(Convert.ToDateTime(datumet), barnid, lämnas, hämtas);

                               Postgres po = new Postgres();
                               po.KontrolleraHämtning(Convert.ToDateTime(datumet), barnid, hamtas);

                               Postgres p4 = new Postgres();
                               p4.TaBortFrånvaro(Convert.ToDateTime(datumet), barnid);
                               
                               MessageBox.Show("Tiden är meddelad och frånvaron är borttagen.");
                           }
                    }
                    
                            else
                           {
                               Postgres p9 = new Postgres();
                               p9.LäggTillTid(Convert.ToDateTime(datumet), barnid, lämnas, hämtas);

                               Postgres po = new Postgres();
                               po.KontrolleraHämtning(Convert.ToDateTime(datumet), barnid, hamtas);
                           }
                }
          
                Postgres p2 = new Postgres();
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid, idag);
                Postgres p3 = new Postgres();
                dataGridViewMeddelaFrånvaro.DataSource = null;
                dataGridViewMeddelaFrånvaro.DataSource = p3.HämtaBarnsFrånvaro(aktuelltbarn.Barnid, idag);
            }
            MetodHämtaBarnetsTid(datum);
            comboBoxFrån1.Text = "hh";
            comboBoxFrån2.Text = "mm";
            comboBoxTill1.Text = "hh";
            comboBoxTill2.Text = "mm";   
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
               
                string från1 = comboBoxUppdateraFrån1.Text;
                string från2 = comboBoxUppdateraFrån2.Text;
                string lamnas = från1 + ":" + från2;
                
                string till1 = comboBoxUppdateraTill1.Text;
                string till2 = comboBoxUppdateraTill2.Text;
                string hamtas = till1 + ":" + till2;
                string hamtasAv = textBoxHämtasAv1.Text;

                if (lamnas == ":" && hamtas == ":")
                {
                    MessageBox.Show("Var vänlig och fyll i tider.");
                }
                else if (Convert.ToInt32(från1) > Convert.ToInt32(till1))
                {
                    MessageBox.Show("Var vänlig kontrollera att Uppdatera befintlig tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte anges till en senare tid än när barnet hämtas.");
                }
                else if (från1 == till1 && Convert.ToInt32(från2) > Convert.ToInt32(till2))
                {
                        MessageBox.Show("Var vänlig kontrollera att Uppdatera befintlig tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte anges till en senare tid än när barnet hämtas.");
                }
                else if (hamtas == lamnas)
                {
                    MessageBox.Show("Var vänlig kontrollera att Uppdatera befintlig tid är korrekt ifylld.\n\nTiden som barnet lämnas på förskolan kan inte vara samma tid som barnet hämtas");
                }
                else if (hamtas == "18:05" || hamtas == "18:10" || hamtas == "18:15" || hamtas == "18:20" || hamtas == "18:25" || hamtas == "18:30" || hamtas == "18:35" || hamtas == "18:40" || hamtas == "18:45" || hamtas == "18:50" || hamtas == "18:55")
                {
                    MessageBox.Show("Tiden som barnet hämtas får ej anges till senare än kl 18:00.");
                }
                else
                {
                    p.UppdateraTider(datum, id, lamnas, hamtas, hamtasAv);
                    
                    Postgres p2 = new Postgres();
                    dataGridViewTiderBarn.DataSource = null;
                    dataGridViewTiderBarn.DataSource = p2.HämtaBarnetsTider(aktuelltbarn.Barnid, idag);
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

            Postgres p1 = new Postgres();
            listAktuellaBarn.DataSource = null;
            List<Barn> barnlista = new List<Barn>();
            barnlista = p1.HämtaAktuellaBarn(AktuellPerson.Personid);
            listAktuellaBarn.DataSource = barnlista;
            listAktuellaBarn.ClearSelected();
            textBoxFornamn.Clear();
            textBoxEfternamn.Clear();
            textBoxAllergier.Clear();
            richTextBoxAnnat.Clear();
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
                bool närvaro;

                if (datum < idag)
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
                dataGridViewMeddelaFrånvaro.DataSource = pp.HämtaBarnsFrånvaro(id, idag);
                
                Postgres p4 = new Postgres();
                dataGridViewTiderBarn.DataSource = null;
                dataGridViewTiderBarn.DataSource = p4.HämtaBarnetsTider(id, idag);
            }
        }

        private void uppdateraförälder_Click_2(object sender, EventArgs e)
        {
            Postgres p = new Postgres();

            int id = AktuellPerson.Personid;
            string förnamn = textBoxFörnamnMittKonto.Text;
            string efternamn = textBoxEfternamnMittKonto.Text;
            string telefonnummer = textBoxTelefonnummerMittKonto.Text;
            char[] förstaTvåFörnamn = textBoxFörnamnMittKonto.Text.Take(2).ToArray();
            string nyttFörnamnTvå = new string(förstaTvåFörnamn.Take(2).ToArray());
            char[] förstaTvåEfternamn = textBoxEfternamnMittKonto.Text.Take(2).ToArray();
            string nyttEfternamnTvå = new string(förstaTvåEfternamn.Take(2).ToArray());
            string nyttAnvändnamn = nyttFörnamnTvå.ToLower() + nyttEfternamnTvå.ToLower();

            p.UppdateraPerson(id, förnamn, efternamn, telefonnummer, nyttAnvändnamn);

            AktuellPerson.Användarnamn = nyttAnvändnamn;

            if (textBoxEfternamnMittKonto.Text != AktuellPerson.Efternamn)
            {
                MessageBox.Show("Ditt användarnamn har uppdaterats." + "\n" + "Användarnamn: " + AktuellPerson.Användarnamn);
                AktuellPerson.Efternamn = textBoxEfternamnMittKonto.Text;
                inloggadesAnvändarnamn.Text = AktuellPerson.Förnamn + " " + AktuellPerson.Efternamn;
            }
            else if (textBoxFörnamnMittKonto.Text != AktuellPerson.Förnamn)
            {
                MessageBox.Show("Ditt användarnamn har uppdaterats." + "\n" + "Användarnamn: " + AktuellPerson.Användarnamn);
                AktuellPerson.Förnamn = textBoxFörnamnMittKonto.Text;
                inloggadesAnvändarnamn.Text = AktuellPerson.Förnamn + " " + AktuellPerson.Efternamn;
            }
            else if (textBoxTelefonnummerMittKonto.Text != AktuellPerson.Telefonnr)
            {
                AktuellPerson.Telefonnr = textBoxTelefonnummerMittKonto.Text;
            }

            p.StängConnection();

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

       

        private void textBoxHämtasAv1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }

        private void textBoxFörnamnMittKonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }

        private void textBoxEfternamnMittKonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }

        private void textBoxFornamn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }

        private void textBoxEfternamn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }

        private void textBoxTelefonnummerMittKonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraNummer(e);
            p.StängConnection();
        }
    }
}
