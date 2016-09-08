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

        Postgres p = new Postgres();
        Person person = new Person();

        private void LoggaInButton_Click(object sender, EventArgs e)
        {

            if(andvandarnamnTextbox.Text.ToUpper() == "FÖRÄLDER")
            {
                this.Visible = false;
                StartForalder foralder = new StartForalder();
                foralder.Show();

            }
            else if(andvandarnamnTextbox.Text.ToUpper() == "PERSONAL")
            {
                this.Visible = false;
                StartPersonal personal = new StartPersonal();
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
               // if()    OM man trycker på Enter så Clickas Logga in knappen
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
           /* else if (losenordTextbox.Text == "Lösenord")
            {
                 Om texten är Lösenord så ska INTE PasswordChar vara aktiv
            }*/
        }

        private void förälderTillfälligButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartForalder foralder = new StartForalder();
            foralder.Show();
        }

        private void personalTillfälligButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartPersonal personal = new StartPersonal();
            personal.Show();
        }

        // Johan 

            

        private void TestJohanButton_Click(object sender, EventArgs e)
        {
            
            p.KontrolleraAnvändare(andvandarnamnTextbox.Text, losenordTextbox.Text);

            //if (p.inskrivetAnvändarnamn == person.Användarnamn && p.inskrivetLösenord == person.Lösenord)
            //{
            //    MessageBox.Show("Inloggningen lyckades!");
            //}
            //else
            //{
            //    if(p.inskrivetAnvändarnamn != person.Användarnamn)
            //    {
            //        MessageBox.Show("Felaktigt användarnamn");
            //    }
            //    else if(p.inskrivetLösenord != person.Lösenord)
            //    {
            //        MessageBox.Show("Felaktigt lösenord");
            //    }
            //}
            //testJohanListBox.DataSource = p.HämtaAnvändare();



        }

        // Mathilda


        // Hischam


        //Martin


    }
}
