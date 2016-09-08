namespace Grupp3___Förskolan_Drutten
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.losenordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.andvandarnamnTextbox = new System.Windows.Forms.TextBox();
            this.LoggaInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 443);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.losenordTextbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.andvandarnamnTextbox);
            this.groupBox2.Controls.Add(this.LoggaInButton);
            this.groupBox2.Location = new System.Drawing.Point(71, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(70, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 55);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Skriv endast: personal eller: förälder, utan lösenord \nför att komma till respekt" +
    "ive Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord:";
            // 
            // losenordTextbox
            // 
            this.losenordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losenordTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.losenordTextbox.Location = new System.Drawing.Point(126, 154);
            this.losenordTextbox.Name = "losenordTextbox";
            this.losenordTextbox.Size = new System.Drawing.Size(123, 20);
            this.losenordTextbox.TabIndex = 3;
            this.losenordTextbox.Text = "Lösenord";
            this.losenordTextbox.Enter += new System.EventHandler(this.losenordTextbox_Enter);
            this.losenordTextbox.Leave += new System.EventHandler(this.losenordTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn:";
            // 
            // andvandarnamnTextbox
            // 
            this.andvandarnamnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andvandarnamnTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.andvandarnamnTextbox.Location = new System.Drawing.Point(126, 112);
            this.andvandarnamnTextbox.Name = "andvandarnamnTextbox";
            this.andvandarnamnTextbox.Size = new System.Drawing.Size(123, 20);
            this.andvandarnamnTextbox.TabIndex = 2;
            this.andvandarnamnTextbox.Text = "Användarnamn";
            this.andvandarnamnTextbox.Enter += new System.EventHandler(this.andvandarnamnTextbox_Enter);
            this.andvandarnamnTextbox.Leave += new System.EventHandler(this.andvandarnamnTextbox_Leave);
            // 
            // LoggaInButton
            // 
            this.LoggaInButton.Location = new System.Drawing.Point(221, 204);
            this.LoggaInButton.Name = "LoggaInButton";
            this.LoggaInButton.Size = new System.Drawing.Size(85, 26);
            this.LoggaInButton.TabIndex = 1;
            this.LoggaInButton.Text = "Logga in";
            this.LoggaInButton.UseVisualStyleBackColor = true;
            this.LoggaInButton.Click += new System.EventHandler(this.LoggaInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupp3___Förskolan_Drutten.Properties.Resources.Blådrutten;
            this.pictureBox1.Location = new System.Drawing.Point(191, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(127, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 600);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggning";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox losenordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox andvandarnamnTextbox;
        private System.Windows.Forms.Button LoggaInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

