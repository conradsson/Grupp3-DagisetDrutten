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
        public StartFörälderMobil()
        {
            InitializeComponent();
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
            menyButtonÖppnad.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
            informationButton.BackgroundImage = Properties.Resources.informationButtonDrutten;
        }
        private void informationButton_MouseDown(object sender, MouseEventArgs e)
        {
            informationButton.BackgroundImage = Properties.Resources.informationButtonDruttenPushed;
        }

        private void mittKontoButton_Click(object sender, EventArgs e)
        {


            MenyPanel.Visible = false;
            menyButtonÖppnad.Visible = false;
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
    }
}
