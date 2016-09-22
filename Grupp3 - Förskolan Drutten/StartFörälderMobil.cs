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
    public partial class StartFörälderMobil : Form
    {
        DateTime datummetod = DateTime.Today;
        Postgres p = new Postgres();
        Person AktuellPerson = new Person()
        {
            Användarnamn = "jaho",
            Förnamn = "James",
            Efternamn = "Hooper",
            Personid = 11,
            Telefonnr = "070-7591018",
            Lösenord = "1234",
            ÄrFörälder = true,
            ÄrPersonal = false,

    };
        
        public StartFörälderMobil()
        {
            InitializeComponent();
            listBoxInlägg.ClearSelected();
            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggFörälder();

            informationTabControl.Visible = true;

            inloggadAnvändareLabel.Text = AktuellPerson.Förnamn + " " + AktuellPerson.Efternamn;
            
        }

        private void menyButton_Click(object sender, EventArgs e)
        {
            MenyPanel.Visible = true;
            menyButtonÖppnad.Visible = true;
            menyButton.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
        }
        private void menyButton_MouseDown(object sender, MouseEventArgs e)
        {
            menyButton.BackgroundImage = Properties.Resources.MiniMobilButtonDruttenPushed;
        }
        private void menyButtonÖppnad_Click(object sender, EventArgs e)
        {
            MenyPanel.Visible = false;
            menyButtonÖppnad.Visible = false;
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
        }
        private void menyButtonÖppnad_MouseDown(object sender, MouseEventArgs e)
        {
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDruttenPushed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            klocklabel2.Text = DateTime.Now.ToLongTimeString().ToString();
            klocklabel1.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void inloggadButton_MouseDown(object sender, MouseEventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenPushedLängre;
        }

        private void inloggadButton_Click(object sender, EventArgs e)
        {
            inloggadButton.BackgroundImage = Properties.Resources.inloggadButtonDruttenLängre;
        }

        private void informationButton_Click(object sender, EventArgs e)
        {


            MenyPanel.Visible = false;
            menyButtonÖppnad.Visible = false;
            informationTabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            TidertabControl.Visible = false;
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
        }
        private void informationButton_MouseDown(object sender, MouseEventArgs e)
        {
            informationButton.BackgroundImage = Properties.Resources.informationButtonDruttenPushed;
        }

        private void mittKontoButton_Click(object sender, EventArgs e)
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

            MenyPanel.Visible = false;
            menyButtonÖppnad.Visible = false;
            MittKontoTabControl.Visible = true;
            informationTabControl.Visible = false;
            TidertabControl.Visible = false;
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonDrutten;
        }
        private void mittKontoButton_MouseDown(object sender, MouseEventArgs e)
        {
            mittKontoButton.BackgroundImage = Properties.Resources.mittKontoButtonPushed;
        }

        private void tiderButton_Click(object sender, EventArgs e)
        {


            MenyPanel.Visible = false;
            menyButtonÖppnad.Visible = false;
            TidertabControl.Visible = true;
            MittKontoTabControl.Visible = false;
            informationTabControl.Visible = false;
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDrutten;
        }

        private void tiderButton_MouseDown(object sender, MouseEventArgs e)
        {
            tiderButton.BackgroundImage = Properties.Resources.tiderButtonDruttenPushed;
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
                dataGridViewTiderBarn.DataSource = p.HämtaBarnetsTider(aktuelltbarn.Barnid, datummetod);
                //dataGridViewTiderBarn.Columns[1].Visible = false;
                //dataGridViewTiderBarn.Columns[2].Visible = false;

                string tid;
                DateTime datum = monthCalendar3.SelectionStart;
                tid = p.BarnetsHämtaTid(aktuelltbarn.Barnid, datum);

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
                    //p.UppdateraTider(datum, id, lamnas, hamtas);
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
            Barn aktuelltbarn = (Barn)listBoxMeddelaHämtning.SelectedItem;

            int barnid = aktuelltbarn.Barnid;
            string hamtas = textBoxMeddelaHämtning.Text;
            DateTime datum = monthCalendar1.SelectionStart;

            Postgres p = new Postgres();

            p.MeddelaHämtning(barnid, hamtas, datum);


        }

        private void listBoxMeddelaHämtning_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barn aktuelltb = new Barn();
            aktuelltb = (Barn)listBoxMeddelaHämtning.SelectedItem;

            if (aktuelltb != null)
            {
                Postgres p = new Postgres();
                string tid;
                DateTime datum = monthCalendar1.SelectionStart;
                tid = p.BarnetHämtasAv(aktuelltb.Barnid, datum);
                textBoxMeddelaHämtning.Text = tid;
            }
            //else
            //{
            //    MessageBox.Show("Välj ett barn i listan.");
            //}
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Barn aktuelltb = new Barn();
            aktuelltb = (Barn)listBoxMeddelaHämtning.SelectedItem;

            if (aktuelltb != null)
            {
                Postgres p = new Postgres();
                string tid;
                DateTime datum = monthCalendar1.SelectionStart;
                tid = p.BarnetHämtasAv(aktuelltb.Barnid, datum);
                textBoxMeddelaHämtning.Text = tid;
            }
            //else
            //{
            //    MessageBox.Show("Välj ett barn i listan.");
            //}
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

            AktuellPerson.Förnamn = textBoxFörnamnMittKonto.Text;
            AktuellPerson.Efternamn = textBoxEfternamnMittKonto.Text;
            AktuellPerson.Telefonnr = textBoxTelefonnummerMittKonto.Text;
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
                }
                else
                {
                    sjuk = false;
                    ledig = true;
                }

                p.LäggTillFånvaro(datum, id, sjuk, ledig);
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

            AktuellPerson.Förnamn = textBoxFörnamnMittKonto.Text;
            AktuellPerson.Efternamn = textBoxEfternamnMittKonto.Text;
            AktuellPerson.Telefonnr = textBoxTelefonnummerMittKonto.Text;




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

            /*if (p.LösenordsEncrypt(nuvarandeLösenord) == AktuellPerson.Lösenord)
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
            }*/
        }
    }
}

