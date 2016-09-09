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

        
        Person person = new Person();

        //public string Användaren()
        //{
        //    string användare;
        //    användare = andvandarnamnTextbox.Text;
        //    return användare;
        //}

        private void LoggaInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Postgres p = new Postgres();
            // Fungerade inloggning, utan behörighet.
            
            p.HämtaAnvändare(andvandarnamnTextbox.Text, losenordTextbox.Text);
            //p.HämtaAnvändare(andvandarnamnTextbox.Text);


            // TILLFÄLLIG INLOGGNING TILL FÖRÄLDER OCH PERSONAL
            //
            //if(andvandarnamnTextbox.Text.ToUpper() == "FÖRÄLDER")
            //{
            //    this.Visible = false;
            //    StartForalder foralder = new StartForalder();
            //    foralder.Show();

            //}
            //else if(andvandarnamnTextbox.Text.ToUpper() == "PERSONAL")
            //{
            //    this.Visible = false;
            //    StartPersonal personal = new StartPersonal();
            //    personal.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Felaktigt användarnamn.");
            //}

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
            





        }

        // Mathilda


        // Hischam


        //Martin


    }
}
