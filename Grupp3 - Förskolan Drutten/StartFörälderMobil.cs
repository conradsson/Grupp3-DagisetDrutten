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




    }
}
