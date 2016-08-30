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

            if(andvandarnamnTextbox.Text == "Förälder" || andvandarnamnTextbox.Text == "förälder")
            {
                StartForalder foralder = new StartForalder();
                // this.Visible = false;
                foralder.Show();
            }
            else if(andvandarnamnTextbox.Text == "Personal" || andvandarnamnTextbox.Text == "personal")
            {

                StartPersonal personal = new StartPersonal();
                // this.Visible = false;
                personal.Show();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn.");
            }

        }


        //  TextBox Effekter
        private void andvandarnamnTextbox_Enter(object sender, EventArgs e)
        {

            if (andvandarnamnTextbox.Text == "Användarnamn")
            {
                andvandarnamnTextbox.Text = "";
                andvandarnamnTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void losenordTextbox_Enter(object sender, EventArgs e)
        {
            if (losenordTextbox.Text == "Lösenord")
            {
                losenordTextbox.Text = "";
                losenordTextbox.PasswordChar = '*';
                losenordTextbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void andvandarnamnTextbox_Leave(object sender, EventArgs e)
        {
            if (andvandarnamnTextbox.Text == "")
            {
                andvandarnamnTextbox.Text = "Användarnamn";
                andvandarnamnTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void losenordTextbox_Leave(object sender, EventArgs e)
        {
            if (losenordTextbox.Text == "")
            {
                losenordTextbox.Text = "Lösenord";
                losenordTextbox.ForeColor = System.Drawing.Color.Gray;
                
            }
        }
    }
}
