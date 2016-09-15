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
            menyButton.BackgroundImage = Properties.Resources.MiniMobilButtonDrutten;
        }

        private void menyButton_MouseDown(object sender, MouseEventArgs e)
        {
            menyButton.BackgroundImage = Properties.Resources.MiniMobilButtonDruttenPushed;
        }
    }
}
