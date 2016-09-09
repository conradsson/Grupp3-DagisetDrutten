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
    public partial class StartFP : Form
    {
        public StartFP()
        {
            InitializeComponent();
        }

        private void förälderButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartForalder f = new StartForalder();
            f.Show();
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPersonal p = new StartPersonal();
            p.Show();
        }
    }
}
