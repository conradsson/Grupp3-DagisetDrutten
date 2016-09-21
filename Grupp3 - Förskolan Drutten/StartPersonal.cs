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

            NärvarotabControl.Visible = true;
            AktuellPerson = aktuellperson;

            Postgres p = new Postgres();
            DateTime idag = DateTime.Today;
            dataGridViewDagensBarn.DataSource = p.HämtaNärvaro(idag);
            dataGridViewDagensBarn.Columns[1].Visible = false;

            monthCalendar23INärvarohantering.TodayDate = idag;


            labelAntalBarnIdag.Text = dataGridViewDagensBarn.RowCount.ToString() + " Barn på förskolan idag";
            inloggadesAnvändarnamn.Text = aktuellperson.Förnamn +" "+ aktuellperson.Efternamn;

        }

        // Knapp Effekter

        private void informationButton_Click(object sender, EventArgs e)// Information-knappen
        {
            Postgres p = new Postgres();

            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggPersonal();
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

            listBoxSöktaBarn.DataSource = p.HämtanBarn();
            labelAntalSöktaBarn.Text = "Antal barn: " + listBoxSöktaBarn.Items.Count.ToString();
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



            Postgres p = new Postgres();
            dataGridViewDagensBarn.DataSource = p.HämtaNärvaro(DateTime.Today);
            dataGridViewDagensBarn.Columns[1].Visible = false;
            labelAntalBarnIdag.Text = dataGridViewDagensBarn.RowCount.ToString() + " Barn på förskolan idag";

            
            dataGridViewDagensBarn.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            

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



        private void buttonSökValtDatumINärvarohantering_Click(object sender, EventArgs e)
        {
            dataGridViewNärvarandeINärvarohantering.DataSource = null;
            dataGridViewFrånvarandeINärvarohantering.DataSource = null;

            if (NärvarandeRadioButton.Checked == false && FrånvarandeRadioButton.Checked == false)
            {
                MessageBox.Show("Vänligen markera närvarande eller frånvarande.");
            }
            else
            {
            if (NärvarandeRadioButton.Checked)
            {
                label15.Text = "Närvarande:";
                Postgres p = new Postgres();
                DateTime idag = monthCalendar23INärvarohantering.SelectionStart;
                dataGridViewNärvarandeINärvarohantering.DataSource = p.HämtaNärvaroFörNärvarohantering(idag);
                label17.Text = dataGridViewNärvarandeINärvarohantering.RowCount.ToString() + " Barn";
                labelSkrivut.Text = "Skriv ut dagens närvarolista";

                dataGridViewNärvarandeINärvarohantering.Visible = true;
                dataGridViewFrånvarandeINärvarohantering.Visible = false;

            }
            else if (FrånvarandeRadioButton.Checked)
            {
                label15.Text = "Frånvarande:";
                Postgres p = new Postgres();
                DateTime idag = monthCalendar23INärvarohantering.SelectionStart;
                dataGridViewFrånvarandeINärvarohantering.DataSource = p.HämtaFrånvaro(idag);
                label17.Text = dataGridViewNärvarandeINärvarohantering.RowCount.ToString() + " Barn";
                labelSkrivut.Text = "Skriv ut dagens frånvarolista";

                dataGridViewNärvarandeINärvarohantering.Visible = false;
                dataGridViewFrånvarandeINärvarohantering.Visible = true;
            }

            }
        }

        private void nyttInläggButton_Click(object sender, EventArgs e)
        {
            richTextBoxNyText.Clear();
            textBoxNyRubrik.Clear();
            skyddpanel.Visible = true;
            nyttInläggPanel.Location = new Point(304, 54);
            nyttInläggPanel.Visible = true;
            publiceraButton.Visible = true;
            uppdateraInläggButton.Visible = false;

        }

        private void avbrytButton_Click(object sender, EventArgs e)
        {
            if (textBoxNyRubrik.Text == "" || richTextBoxNyText.Text == "")
            {
                richTextBoxNyText.Clear();
                textBoxNyRubrik.Clear();
                skyddpanel.Visible = false;
                nyttInläggPanel.Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Är du säker på att du vill avbryta? " + "\n" + "Ändringar kommer att tas bort.", "Avbryt", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    richTextBoxNyText.Clear();
                    textBoxNyRubrik.Clear();
                    skyddpanel.Visible = false;
                    nyttInläggPanel.Visible = false;
                }
            }
        }

        private void tabortButton_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Information AktuelltInlägg = (Information)listBoxInlägg.SelectedItem;
            DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort det markerade inlägget? " + "\n" + "Inlägget kommer inte kunna återställas.", "Ta bort inlägg", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (AktuelltInlägg != null)
                {
                    p.TaBortInlägg(AktuelltInlägg.Datum, AktuelltInlägg.InläggsId);
                    listBoxInlägg.DataSource = null;
                    listBoxInlägg.DataSource = p.HämtaInläggPersonal();

                }
            }


        }

        private void publiceraButton_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            string fullständigtNamn = AktuellPerson.Förnamn + " " + AktuellPerson.Efternamn;

            p.NyttInlägg(DateTime.Now.ToShortDateString(), textBoxNyRubrik.Text, richTextBoxNyText.Text, fullständigtNamn,EndastFörPersonalCheckBox.Checked);
            skyddpanel.Visible = false;
            nyttInläggPanel.Visible = false;

            listBoxInlägg.DataSource = null;
            listBoxInlägg.DataSource = p.HämtaInläggPersonal();
        }

        private void redigeraButton_Click(object sender, EventArgs e)
        {
            Information AktuelltInlägg = (Information)listBoxInlägg.SelectedItem;

            richTextBoxNyText.Text = AktuelltInlägg.InläggsText;
            textBoxNyRubrik.Text = AktuelltInlägg.InläggsRubrik;

            publiceraButton.Visible = false;
            uppdateraInläggButton.Visible = true;
            skyddpanel.Visible = true;
            nyttInläggPanel.Visible = true;
            nyttInläggPanel.Location = new Point(304, 60);
        }

        private void uppdateraInläggButton_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Information AktuelltInlägg = (Information)listBoxInlägg.SelectedItem;

            if (AktuelltInlägg != null)
            {
                p.UppdateraInlägg(AktuelltInlägg.Datum, textBoxNyRubrik.Text, richTextBoxNyText.Text, AktuelltInlägg.InläggsId,EndastFörPersonalCheckBox.Checked);
                skyddpanel.Visible = false;
                nyttInläggPanel.Visible = false;

                listBoxInlägg.DataSource = null;
                listBoxInlägg.DataSource = p.HämtaInläggPersonal();

            }
        }

        private void listBoxSöktaBarn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Barn AktuelltBarn = (Barn)listBoxSöktaBarn.SelectedItem;

            if (AktuelltBarn != null)
            {

                listBoxVårnadshavare.DataSource = null;
                listBoxVårnadshavare.DisplayMember = "VisaFörälder";
                listBoxVårnadshavare.DataSource = p.HämtaBarnsFörälder(AktuelltBarn.Barnid);

                barnOverigtrichTextBox.Text = AktuelltBarn.Allergier + "\n" + AktuelltBarn.Annat;


            }
        }

        private void buttonSök_Click(object sender, EventArgs e)
        {
            if (checkBoxAvdelning1.Checked == true && checkBoxAvdelning2.Checked == true)
            {
                Postgres p = new Postgres();
                listBoxVårnadshavare.DataSource = null;
                listBoxSöktaBarn.DataSource = p.HämtaBarnEfterSök(textBoxSökRuta.Text);
                labelAntalSöktaBarn.Text = "Antal barn: " + listBoxSöktaBarn.Items.Count.ToString();

            }

            else if (checkBoxAvdelning1.Checked == true)
            {
                Postgres p = new Postgres();
                listBoxVårnadshavare.DataSource = null;
                listBoxSöktaBarn.DataSource = p.HämtaBarnEfterSök1(textBoxSökRuta.Text);
                labelAntalSöktaBarn.Text = "Antal barn: " + listBoxSöktaBarn.Items.Count.ToString();
            }
            else if (checkBoxAvdelning2.Checked == true)
            {
                Postgres p = new Postgres();
                listBoxVårnadshavare.DataSource = null;
                listBoxSöktaBarn.DataSource = p.HämtaBarnEfterSök2(textBoxSökRuta.Text);
                labelAntalSöktaBarn.Text = "Antal barn: " + listBoxSöktaBarn.Items.Count.ToString();
            }
            else
            {
                Postgres p = new Postgres();
                listBoxVårnadshavare.DataSource = null;
                listBoxSöktaBarn.DataSource = p.HämtaBarnEfterSök(textBoxSökRuta.Text);
                labelAntalSöktaBarn.Text = "Antal barn: " + listBoxSöktaBarn.Items.Count.ToString();
            }
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void buttonVisaDiagram_Click(object sender, EventArgs e)
        {
            labelAntalBarn.Visible = true;
            labelTid.Visible = true;

            dataGridViewDagensBarn.Height = 140;
            buttonDöljDiagram.Visible = true;
            buttonVisaDiagram.Visible = false;
            chartBarnensTider.Visible = true;

            int kollaTid = 06;
            int tid = 06;
            for (int i = 0; i < 11; i++)
            {
                Postgres p = new Postgres();
                this.chartBarnensTider.Series["Barn lämnas"].Points.AddXY(tid++, p.HämtaDagensTider(DateTime.Today, kollaTid++));

          }
            int kollaTid2 = 06;
            int tid2 = 06;
            for (int i = 0; i < 11; i++)
            {
                Postgres p = new Postgres();
                this.chartBarnensTider.Series["Barn hämtas"].Points.AddXY(tid2++, p.HämtaDagensTiderHämtas(DateTime.Today, kollaTid2++));

            }

        }

        private void uppdateraförälder_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();

            int id = AktuellPerson.Personid;
            string förnamn = textBoxFörnamnMittkonto.Text;
            string efternamn = textBoxEfternamnMittkonto.Text;
            string telefonnummer = textBoxTelefonnrMittkonto.Text;

            p.UppdateraPerson(id, förnamn, efternamn, telefonnummer);

            AktuellPerson.Förnamn = textBoxFörnamnMittkonto.Text;
            AktuellPerson.Efternamn = textBoxEfternamnMittkonto.Text;
            AktuellPerson.Telefonnr = textBoxTelefonnrMittkonto.Text;



        }

        private void buttonSökAntalFramtidaBarn_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            Postgres p1 = new Postgres();

            labelTotaltAntalBarn.Visible = true;
            labelHurMångaBarnUnderSöktaDatum.Visible = true;
            labelTotaltAntalBarn.Text = "Totalt antal barn på förskolan mellan " + dateTimePickerFrån.Value.ToString("yy-MM-dd") + " och " + dateTimePickerTill.Value.ToString("yy-MM-dd") + ": ";
            labelHurMångaBarnUnderSöktaDatum.Text = p1.HämtaFramtidaTider(dateTimePickerFrån.Value, dateTimePickerTill.Value).ToString() + " Barn";

            dataGridViewAllaFramtidaBarn.DataSource = p.HämtaFramtidaBarn(dateTimePickerFrån.Value, dateTimePickerTill.Value);

            

        }

        private void buttonUppdateraNärvaro_Click(object sender, EventArgs e)
        {
            Närvaro aktuelltBarn = new Närvaro();

            foreach (DataGridViewRow row in dataGridViewDagensBarn.Rows)
            {

                if (row.Cells[6].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[6].Value))
                    {
                        Postgres p = new Postgres();
                        aktuelltBarn.barnid = Convert.ToInt32(row.Cells[1].Value);
                        aktuelltBarn.närvarande = Convert.ToBoolean(row.Cells[6].Value);
                        aktuelltBarn.Datum = Convert.ToDateTime(row.Cells[0].Value);

                        p.LäggTillNärvaroFörIdag(aktuelltBarn.Datum, aktuelltBarn.barnid, aktuelltBarn.närvarande);
                    }
                    else
                    {
                            Postgres p = new Postgres();
                            aktuelltBarn.barnid = Convert.ToInt32(row.Cells[1].Value);
                            aktuelltBarn.närvarande = Convert.ToBoolean(row.Cells[6].Value);
                            aktuelltBarn.Datum = Convert.ToDateTime(row.Cells[0].Value);

                            p.TaBortNärvaroFörIdag(aktuelltBarn.Datum, aktuelltBarn.barnid, aktuelltBarn.närvarande);

                    }
                }
                if (row.Cells[5].Value != null)
                {
                    if (Convert.ToBoolean(row.Cells[7].Value))
                    {
                        Postgres p = new Postgres();
                        aktuelltBarn.barnid = Convert.ToInt32(row.Cells[1].Value);
                        aktuelltBarn.hämtad = Convert.ToBoolean(row.Cells[7].Value);
                        aktuelltBarn.Datum = Convert.ToDateTime(row.Cells[0].Value);

                        p.LäggTillHämtadFörIdag(aktuelltBarn.Datum, aktuelltBarn.barnid, aktuelltBarn.hämtad);
                    }
                    else
                    {
                        Postgres p = new Postgres();
                        aktuelltBarn.barnid = Convert.ToInt32(row.Cells[1].Value);
                        aktuelltBarn.hämtad = Convert.ToBoolean(row.Cells[7].Value);
                        aktuelltBarn.Datum = Convert.ToDateTime(row.Cells[0].Value);

                        p.TaBortHämtadFörIdag(aktuelltBarn.Datum, aktuelltBarn.barnid, aktuelltBarn.hämtad);
                    }
                }

            }
        }

        //private void skrivut_Click(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            panelskrivut.Visible = true;
            panelskrivut.Location = new Point(144, 17);
            dataGridSkrivut.Visible = false;

            if (NärvarandeRadioButton.Checked)
            {
                statuspanel.Text = "Närvarande.";
                dataGridSkrivut.DataSource = null;
                Postgres p = new Postgres();
                dataGridSkrivut.DataSource = p.HämtaNärvaro(monthCalendar23INärvarohantering.SelectionStart);
                dataGridSkrivut.Visible = true;
                panelskrivfrånvaro.Visible = false;
                panelskriv.Visible = true;

            }
            else if (FrånvarandeRadioButton.Checked)
            {
                statuspanel.Text = "Frånvarande.";
                dataGridViewFrånvaroSkrivut.DataSource = null;
                Postgres p = new Postgres();
                dataGridViewFrånvaroSkrivut.DataSource = p.HämtaFrånvaro(monthCalendar23INärvarohantering.SelectionStart);
                dataGridViewFrånvaroSkrivut.Visible = true;
                panelskriv.Visible = false;
                panelskrivfrånvaro.Visible = true;

            }
            

        }

        private void panelskriv_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            panelskrivut.Visible = false;
        }

        private void panelavbryt_Click(object sender, EventArgs e)
        {
            panelskrivut.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridSkrivut.Width, this.dataGridSkrivut.Height);
            dataGridSkrivut.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridSkrivut.Width, this.dataGridSkrivut.Height));
            Bitmap bmp = Properties.Resources.BlådruttenMellan;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(statuspanel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(21, 120));
            e.Graphics.DrawImage(bm,21,140);
        }

        private void panelskrivfrånvaro_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
            panelskrivut.Visible = false;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridViewFrånvaroSkrivut.Width, this.dataGridViewFrånvaroSkrivut.Height);
            dataGridViewFrånvaroSkrivut.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewFrånvaroSkrivut.Width, this.dataGridViewFrånvaroSkrivut.Height));
            Bitmap bmp = Properties.Resources.BlådruttenMellan;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(statuspanel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(21, 120));
            e.Graphics.DrawImage(bm, 21, 140);
        }

        private void buttonDöljDiagram_Click(object sender, EventArgs e)
        {
            dataGridViewDagensBarn.Height = 240;
            buttonVisaDiagram.Visible = true;
            buttonDöljDiagram.Visible = false;
            chartBarnensTider.Visible = false;
            labelAntalBarn.Visible = false;
            labelTid.Visible = false;
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

        private void ändraLösenAvbryt_Click(object sender, EventArgs e)
        {
                ändraLösenPanel.Visible = false;
        }

        private void ändraLösenordButton_Click(object sender, EventArgs e)
        {
            textBoxNuvarandeLösen.Clear();
            textBoxNyttLösen.Clear();
            textBoxNyttLösen2.Clear();
            ändraLösenPanel.Visible = true;
            ändraLösenPanel.Location = new Point(33, 37);
        }
    }
}
