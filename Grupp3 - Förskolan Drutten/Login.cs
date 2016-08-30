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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoggaInButton_Click(object sender, EventArgs e)
        {
            StartForalder foralder = new StartForalder();
           // this.Visible = false;
            foralder.Show();
        }
       
        
        
        //  TextBox Effekter
        private void andvandarnamnTextbox_Enter(object sender, EventArgs e)
        {
            if (andvandarnamnTextbox.Text == "Användarnamn")
            {
                andvandarnamnTextbox.Text = "";
            }
        }

        private void losenordTextbox_Enter(object sender, EventArgs e)
        {
            if (losenordTextbox.Text == "Lösenord")
            {
                losenordTextbox.Text = "";
            }
        }

        private void andvandarnamnTextbox_Leave(object sender, EventArgs e)
        {
            if (andvandarnamnTextbox.Text == "")
            {
                andvandarnamnTextbox.Text = "Användarnamn";
            }
        }

        private void losenordTextbox_Leave(object sender, EventArgs e)
        {
            if (losenordTextbox.Text == "")
            {
                losenordTextbox.Text = "Lösenord";
            }
        }
    }
}
