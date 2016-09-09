namespace Grupp3___Förskolan_Drutten
{
    partial class StartFP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personalButton = new System.Windows.Forms.Button();
            this.förälderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupp3___Förskolan_Drutten.Properties.Resources.Blådrutten;
            this.pictureBox1.Location = new System.Drawing.Point(285, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 112);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.personalButton);
            this.groupBox2.Controls.Add(this.förälderButton);
            this.groupBox2.Location = new System.Drawing.Point(165, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Välj vilken roll du vill logga in med.";
            // 
            // personalButton
            // 
            this.personalButton.Location = new System.Drawing.Point(219, 105);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(75, 23);
            this.personalButton.TabIndex = 8;
            this.personalButton.Text = "Personal";
            this.personalButton.UseVisualStyleBackColor = true;
            this.personalButton.Click += new System.EventHandler(this.personalButton_Click);
            // 
            // förälderButton
            // 
            this.förälderButton.Location = new System.Drawing.Point(115, 105);
            this.förälderButton.Name = "förälderButton";
            this.förälderButton.Size = new System.Drawing.Size(75, 23);
            this.förälderButton.TabIndex = 7;
            this.förälderButton.Text = "Förälder";
            this.förälderButton.UseVisualStyleBackColor = true;
            this.förälderButton.Click += new System.EventHandler(this.förälderButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(94, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 321);
            this.panel1.TabIndex = 6;
            // 
            // StartFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "StartFP";
            this.Text = "StartFP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button förälderButton;
        private System.Windows.Forms.Panel panel1;
    }
}