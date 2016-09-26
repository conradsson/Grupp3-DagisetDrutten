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


        // Logga in-knappen.
        private void LoggaInButton_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            p.HämtaAnvändare(andvandarnamnTextbox.Text, losenordTextbox.Text);

            if (p.Inloggad == true)
            {
                this.Visible = false;
            }
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

             //  Används för att och för att döjla lösenordet. TA BORT DENNA INNAN FINAL RELEASE!
        private void losenordTextbox_Enter(object sender, EventArgs e)
        {
            losenordTextbox.Text = "1234";

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
           // losenordTextbox.Text = "1234";

        }

        // Lösenordskrypteraren. mini-applikation som krypterar det inmatade lösenordet.
        private void EncryptTestButton_Click(object sender, EventArgs e)
        {
            Postgres p = new Postgres();
            encryptTextBox.Clear();
            encryptTextBox.Text = p.LösenordsEncrypt(losenordENCRYPTtextBox.Text);
        }
        // Tillhör Lösenordskrypteraren.
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(encryptTextBox.Text);
        }
        // Tillhör Lösenordskrypteraren.
        private void rensaEncryptButton_Click(object sender, EventArgs e)
        {
            encryptTextBox.Clear();
            losenordENCRYPTtextBox.Clear();
        }

        // Avsluta-knapp, högst upp till höger.
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Är du säker på att du vill avsluta? ", "Avsluta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Öppnar formen för Mobil. Endast för presentation.
        private void MobilLink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MobilBankId b = new MobilBankId();

            b.Show();
        }

        private void minimeraButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void andvandarnamnTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Postgres p = new Postgres();
            p.ValideraText(e);
            p.StängConnection();
        }
    }
}
