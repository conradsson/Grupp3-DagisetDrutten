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
    }
}
