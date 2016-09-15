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

        public string inskrivetAnvändarnamn;
        public string inskrivetLösenord;

        //public string Användaren()
        //{
        //    string användare;
        //    användare = andvandarnamnTextbox.Text;
        //    return användare;
        //}

        private void LoggaInButton_Click(object sender, EventArgs e)
        {
            
            p.HämtaAnvändare(andvandarnamnTextbox.Text, losenordTextbox.Text);

            inskrivetAnvändarnamn = andvandarnamnTextbox.Text;
            inskrivetLösenord = losenordTextbox.Text;

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


            
        private void andvandarnamnTextbox_Enter(object sender, EventArgs e)
        {

            if (andvandarnamnTextbox.Text == "Användarnamn")
            {
                andvandarnamnTextbox.Text = "";
                andvandarnamnTextbox.ForeColor = System.Drawing.Color.Black;
               // if()    OM man trycker på Enter så Clickas Logga in knappen
            }
        }

             //  Används för attoch för att döjla lösenordet. AVSTÄNGD!
        private void losenordTextbox_Enter(object sender, EventArgs e)
        {
            losenordTextbox.Text = "1234";
           /* if (losenordTextbox.Text == "Lösenord")
            {
                losenordTextbox.Text = "";
                losenordTextbox.PasswordChar = '*';
                losenordTextbox.ForeColor = System.Drawing.Color.Black;
            }*/
        }

          // Om användarnamn är tomt blir texten "Användarnamn". 
        private void andvandarnamnTextbox_Leave(object sender, EventArgs e)
        {
            if (andvandarnamnTextbox.Text == "")
            {
                andvandarnamnTextbox.Text = "Användarnamn";
                andvandarnamnTextbox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Om lösenord är tomt blir texten "Lösenord". AVSTÄNGD!
        private void losenordTextbox_Leave(object sender, EventArgs e)
        {
            losenordTextbox.Text = "1234";

            /* if (losenordTextbox.Text == "")
             {
                 losenordTextbox.Text = "Lösenord";
                 losenordTextbox.ForeColor = System.Drawing.Color.Gray;
             }*/
        }




        // Johan 

        private void EncryptTestButton_Click(object sender, EventArgs e)
        {


            encryptTextBox.Clear();
            encryptTextBox.Text = p.LösenordsEncrypt(losenordENCRYPTtextBox.Text);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(encryptTextBox.Text);
        }

        private void rensaEncryptButton_Click(object sender, EventArgs e)
        {
            encryptTextBox.Clear();
            losenordENCRYPTtextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Är du säker på att du vill avsluta? ", "Avsluta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MobilLink_Click(object sender, EventArgs e)
        {
            MobilBankId b = new MobilBankId();

            b.Show();
        }

        // Mathilda


        // Hischam


        //Martin


    }
}
