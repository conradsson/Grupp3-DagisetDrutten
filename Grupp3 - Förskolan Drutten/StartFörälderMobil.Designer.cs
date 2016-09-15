namespace Grupp3___Förskolan_Drutten
{
    partial class StartFörälderMobil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFörälderMobil));
            this.menyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kontoTypLabel = new System.Windows.Forms.Label();
            this.MenyPanel = new System.Windows.Forms.Panel();
            this.menyButtonÖppnad = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.Button();
            this.tiderButton = new System.Windows.Forms.Button();
            this.mittKontoButton = new System.Windows.Forms.Button();
            this.klocklabel2 = new System.Windows.Forms.Label();
            this.klocklabel1 = new System.Windows.Forms.Label();
            this.Klockan = new System.Windows.Forms.Button();
            this.inloggadButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menyButton
            // 
            this.menyButton.BackColor = System.Drawing.Color.Transparent;
            this.menyButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.MiniMobilButtonDrutten;
            this.menyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menyButton.FlatAppearance.BorderSize = 0;
            this.menyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menyButton.Location = new System.Drawing.Point(12, 77);
            this.menyButton.Name = "menyButton";
            this.menyButton.Size = new System.Drawing.Size(56, 50);
            this.menyButton.TabIndex = 0;
            this.menyButton.UseVisualStyleBackColor = false;
            this.menyButton.Click += new System.EventHandler(this.menyButton_Click);
            this.menyButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menyButton_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.BlådruttenMellan;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kontoTypLabel
            // 
            this.kontoTypLabel.AutoSize = true;
            this.kontoTypLabel.BackColor = System.Drawing.Color.Transparent;
            this.kontoTypLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontoTypLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kontoTypLabel.Location = new System.Drawing.Point(101, 51);
            this.kontoTypLabel.Name = "kontoTypLabel";
            this.kontoTypLabel.Size = new System.Drawing.Size(82, 23);
            this.kontoTypLabel.TabIndex = 5;
            this.kontoTypLabel.Text = "Förälder";
            // 
            // MenyPanel
            // 
            this.MenyPanel.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.DruttenMeny1;
            this.MenyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenyPanel.Controls.Add(this.informationButton);
            this.MenyPanel.Controls.Add(this.tiderButton);
            this.MenyPanel.Controls.Add(this.mittKontoButton);
            this.MenyPanel.Controls.Add(this.menyButtonÖppnad);
            this.MenyPanel.Location = new System.Drawing.Point(12, 77);
            this.MenyPanel.Name = "MenyPanel";
            this.MenyPanel.Size = new System.Drawing.Size(158, 314);
            this.MenyPanel.TabIndex = 7;
            this.MenyPanel.Visible = false;
            // 
            // menyButtonÖppnad
            // 
            this.menyButtonÖppnad.BackColor = System.Drawing.Color.Transparent;
            this.menyButtonÖppnad.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.MiniMobilButtonDrutten;
            this.menyButtonÖppnad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menyButtonÖppnad.FlatAppearance.BorderSize = 0;
            this.menyButtonÖppnad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menyButtonÖppnad.Location = new System.Drawing.Point(-1, -1);
            this.menyButtonÖppnad.Name = "menyButtonÖppnad";
            this.menyButtonÖppnad.Size = new System.Drawing.Size(56, 50);
            this.menyButtonÖppnad.TabIndex = 8;
            this.menyButtonÖppnad.UseVisualStyleBackColor = false;
            this.menyButtonÖppnad.Visible = false;
            this.menyButtonÖppnad.Click += new System.EventHandler(this.menyButtonÖppnad_Click);
            this.menyButtonÖppnad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menyButtonÖppnad_MouseDown);
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.Color.LightGray;
            this.informationButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.informationButtonDrutten;
            this.informationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informationButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.informationButton.FlatAppearance.BorderSize = 0;
            this.informationButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.informationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.informationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationButton.ForeColor = System.Drawing.Color.Black;
            this.informationButton.Location = new System.Drawing.Point(-57, 84);
            this.informationButton.Name = "informationButton";
            this.informationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.informationButton.Size = new System.Drawing.Size(207, 45);
            this.informationButton.TabIndex = 16;
            this.informationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informationButton.UseVisualStyleBackColor = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            this.informationButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.informationButton_MouseDown);
            // 
            // tiderButton
            // 
            this.tiderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.tiderButtonDrutten;
            this.tiderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tiderButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.tiderButton.FlatAppearance.BorderSize = 0;
            this.tiderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.tiderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiderButton.ForeColor = System.Drawing.Color.Black;
            this.tiderButton.Location = new System.Drawing.Point(-57, 184);
            this.tiderButton.Name = "tiderButton";
            this.tiderButton.Size = new System.Drawing.Size(207, 45);
            this.tiderButton.TabIndex = 18;
            this.tiderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tiderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tiderButton.UseVisualStyleBackColor = false;
            this.tiderButton.Click += new System.EventHandler(this.tiderButton_Click);
            this.tiderButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tiderButton_MouseDown);
            // 
            // mittKontoButton
            // 
            this.mittKontoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.mittKontoButtonDrutten;
            this.mittKontoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mittKontoButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.mittKontoButton.FlatAppearance.BorderSize = 0;
            this.mittKontoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.mittKontoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mittKontoButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mittKontoButton.ForeColor = System.Drawing.Color.Black;
            this.mittKontoButton.Location = new System.Drawing.Point(-57, 134);
            this.mittKontoButton.Name = "mittKontoButton";
            this.mittKontoButton.Size = new System.Drawing.Size(207, 45);
            this.mittKontoButton.TabIndex = 17;
            this.mittKontoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mittKontoButton.UseVisualStyleBackColor = false;
            this.mittKontoButton.Click += new System.EventHandler(this.mittKontoButton_Click);
            this.mittKontoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mittKontoButton_MouseDown);
            // 
            // klocklabel2
            // 
            this.klocklabel2.AutoSize = true;
            this.klocklabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.klocklabel2.Location = new System.Drawing.Point(197, 36);
            this.klocklabel2.Name = "klocklabel2";
            this.klocklabel2.Size = new System.Drawing.Size(22, 13);
            this.klocklabel2.TabIndex = 35;
            this.klocklabel2.Text = "Tid";
            // 
            // klocklabel1
            // 
            this.klocklabel1.AutoSize = true;
            this.klocklabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.klocklabel1.Location = new System.Drawing.Point(263, 36);
            this.klocklabel1.Name = "klocklabel1";
            this.klocklabel1.Size = new System.Drawing.Size(38, 13);
            this.klocklabel1.TabIndex = 34;
            this.klocklabel1.Text = "Datum";
            // 
            // Klockan
            // 
            this.Klockan.BackColor = System.Drawing.Color.Transparent;
            this.Klockan.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.ButtonDrutten3;
            this.Klockan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Klockan.FlatAppearance.BorderSize = 0;
            this.Klockan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Klockan.Location = new System.Drawing.Point(184, 32);
            this.Klockan.Name = "Klockan";
            this.Klockan.Size = new System.Drawing.Size(164, 20);
            this.Klockan.TabIndex = 33;
            this.Klockan.UseVisualStyleBackColor = false;
            // 
            // inloggadButton
            // 
            this.inloggadButton.BackColor = System.Drawing.Color.Transparent;
            this.inloggadButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.inloggadButtonDruttenLängre;
            this.inloggadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inloggadButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.inloggadButton.FlatAppearance.BorderSize = 0;
            this.inloggadButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.inloggadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.inloggadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.inloggadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inloggadButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inloggadButton.ForeColor = System.Drawing.Color.Black;
            this.inloggadButton.Location = new System.Drawing.Point(184, 54);
            this.inloggadButton.Name = "inloggadButton";
            this.inloggadButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inloggadButton.Size = new System.Drawing.Size(164, 20);
            this.inloggadButton.TabIndex = 36;
            this.inloggadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inloggadButton.UseVisualStyleBackColor = false;
            this.inloggadButton.Click += new System.EventHandler(this.inloggadButton_Click);
            this.inloggadButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inloggadButton_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartFörälderMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.Background1024x600;
            this.ClientSize = new System.Drawing.Size(339, 563);
            this.Controls.Add(this.inloggadButton);
            this.Controls.Add(this.klocklabel2);
            this.Controls.Add(this.klocklabel1);
            this.Controls.Add(this.Klockan);
            this.Controls.Add(this.kontoTypLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenyPanel);
            this.Controls.Add(this.menyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartFörälderMobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartFörälderMobil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kontoTypLabel;
        private System.Windows.Forms.Panel MenyPanel;
        private System.Windows.Forms.Button menyButtonÖppnad;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button tiderButton;
        private System.Windows.Forms.Button mittKontoButton;
        private System.Windows.Forms.Label klocklabel2;
        private System.Windows.Forms.Label klocklabel1;
        private System.Windows.Forms.Button Klockan;
        private System.Windows.Forms.Button inloggadButton;
        private System.Windows.Forms.Timer timer1;
    }
}