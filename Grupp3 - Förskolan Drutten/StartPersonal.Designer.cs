namespace Grupp3___Förskolan_Drutten
{
    partial class StartPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPersonal));
            this.kontoTypLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informationTabControl = new System.Windows.Forms.TabControl();
            this.senasteTabPage = new System.Windows.Forms.TabPage();
            this.omTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoggaUtLinkLabel = new System.Windows.Forms.LinkLabel();
            this.inloggadSomNamnLabel = new System.Windows.Forms.Label();
            this.inloggadSomLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informationButton = new System.Windows.Forms.Button();
            this.närvaroButton = new System.Windows.Forms.Button();
            this.tiderButton = new System.Windows.Forms.Button();
            this.mittKontoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MittKontoTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.informationTabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MittKontoTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kontoTypLabel
            // 
            this.kontoTypLabel.AutoSize = true;
            this.kontoTypLabel.BackColor = System.Drawing.Color.Transparent;
            this.kontoTypLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontoTypLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kontoTypLabel.Location = new System.Drawing.Point(141, 71);
            this.kontoTypLabel.Name = "kontoTypLabel";
            this.kontoTypLabel.Size = new System.Drawing.Size(94, 25);
            this.kontoTypLabel.TabIndex = 3;
            this.kontoTypLabel.Text = "Personal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grupp3___Förskolan_Drutten.Properties.Resources.BlådruttenMellan;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.loggaBox_Click);
            // 
            // informationTabControl
            // 
            this.informationTabControl.Controls.Add(this.senasteTabPage);
            this.informationTabControl.Controls.Add(this.omTabPage);
            this.informationTabControl.Location = new System.Drawing.Point(193, 30);
            this.informationTabControl.Name = "informationTabControl";
            this.informationTabControl.SelectedIndex = 0;
            this.informationTabControl.Size = new System.Drawing.Size(748, 389);
            this.informationTabControl.TabIndex = 14;
            this.informationTabControl.Visible = false;
            // 
            // senasteTabPage
            // 
            this.senasteTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.senasteTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.senasteTabPage.Location = new System.Drawing.Point(4, 22);
            this.senasteTabPage.Name = "senasteTabPage";
            this.senasteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.senasteTabPage.Size = new System.Drawing.Size(740, 363);
            this.senasteTabPage.TabIndex = 0;
            this.senasteTabPage.Text = "Senaste";
            this.senasteTabPage.UseVisualStyleBackColor = true;
            // 
            // omTabPage
            // 
            this.omTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.omTabPage.Location = new System.Drawing.Point(4, 22);
            this.omTabPage.Name = "omTabPage";
            this.omTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.omTabPage.Size = new System.Drawing.Size(740, 363);
            this.omTabPage.TabIndex = 1;
            this.omTabPage.Text = "Om Druttens förskola";
            this.omTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.MittKontoTabControl);
            this.groupBox1.Controls.Add(this.LoggaUtLinkLabel);
            this.groupBox1.Controls.Add(this.inloggadSomNamnLabel);
            this.groupBox1.Controls.Add(this.inloggadSomLabel);
            this.groupBox1.Controls.Add(this.informationTabControl);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(24, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LoggaUtLinkLabel
            // 
            this.LoggaUtLinkLabel.AutoSize = true;
            this.LoggaUtLinkLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.LoggaUtLinkLabel.Location = new System.Drawing.Point(97, 30);
            this.LoggaUtLinkLabel.Name = "LoggaUtLinkLabel";
            this.LoggaUtLinkLabel.Size = new System.Drawing.Size(49, 13);
            this.LoggaUtLinkLabel.TabIndex = 5;
            this.LoggaUtLinkLabel.TabStop = true;
            this.LoggaUtLinkLabel.Text = "Logga ut";
            this.LoggaUtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoggaUtLinkLabel_LinkClicked);
            // 
            // inloggadSomNamnLabel
            // 
            this.inloggadSomNamnLabel.AutoSize = true;
            this.inloggadSomNamnLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.inloggadSomNamnLabel.Location = new System.Drawing.Point(97, 13);
            this.inloggadSomNamnLabel.Name = "inloggadSomNamnLabel";
            this.inloggadSomNamnLabel.Size = new System.Drawing.Size(85, 13);
            this.inloggadSomNamnLabel.TabIndex = 20;
            this.inloggadSomNamnLabel.Text = "(Användarnamn)";
            // 
            // inloggadSomLabel
            // 
            this.inloggadSomLabel.AutoSize = true;
            this.inloggadSomLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.inloggadSomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inloggadSomLabel.Location = new System.Drawing.Point(15, 13);
            this.inloggadSomLabel.Name = "inloggadSomLabel";
            this.inloggadSomLabel.Size = new System.Drawing.Size(90, 13);
            this.inloggadSomLabel.TabIndex = 19;
            this.inloggadSomLabel.Text = "Inloggad som: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.DruttenMeny1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.informationButton);
            this.panel1.Controls.Add(this.närvaroButton);
            this.panel1.Controls.Add(this.tiderButton);
            this.panel1.Controls.Add(this.mittKontoButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 435);
            this.panel1.TabIndex = 4;
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.Color.LightGray;
            this.informationButton.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.ButtonDrutten2;
            this.informationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informationButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.informationButton.FlatAppearance.BorderSize = 0;
            this.informationButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.informationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.informationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationButton.ForeColor = System.Drawing.Color.Black;
            this.informationButton.Location = new System.Drawing.Point(32, 78);
            this.informationButton.Name = "informationButton";
            this.informationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.informationButton.Size = new System.Drawing.Size(163, 45);
            this.informationButton.TabIndex = 5;
            this.informationButton.Text = "Information";
            this.informationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.informationButton.UseVisualStyleBackColor = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // närvaroButton
            // 
            this.närvaroButton.BackColor = System.Drawing.Color.Gainsboro;
            this.närvaroButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("närvaroButton.BackgroundImage")));
            this.närvaroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.närvaroButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.närvaroButton.FlatAppearance.BorderSize = 0;
            this.närvaroButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.närvaroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.närvaroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.närvaroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.närvaroButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.närvaroButton.ForeColor = System.Drawing.Color.Black;
            this.närvaroButton.Location = new System.Drawing.Point(32, 228);
            this.närvaroButton.Name = "närvaroButton";
            this.närvaroButton.Size = new System.Drawing.Size(163, 45);
            this.närvaroButton.TabIndex = 8;
            this.närvaroButton.Text = "Närvaro";
            this.närvaroButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.närvaroButton.UseVisualStyleBackColor = false;
            // 
            // tiderButton
            // 
            this.tiderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tiderButton.BackgroundImage")));
            this.tiderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tiderButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.tiderButton.FlatAppearance.BorderSize = 0;
            this.tiderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.tiderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiderButton.ForeColor = System.Drawing.Color.Black;
            this.tiderButton.Location = new System.Drawing.Point(32, 178);
            this.tiderButton.Name = "tiderButton";
            this.tiderButton.Size = new System.Drawing.Size(163, 45);
            this.tiderButton.TabIndex = 7;
            this.tiderButton.Text = "Tider";
            this.tiderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tiderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tiderButton.UseVisualStyleBackColor = false;
            // 
            // mittKontoButton
            // 
            this.mittKontoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mittKontoButton.BackgroundImage")));
            this.mittKontoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mittKontoButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.mittKontoButton.FlatAppearance.BorderSize = 0;
            this.mittKontoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.mittKontoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mittKontoButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mittKontoButton.ForeColor = System.Drawing.Color.Black;
            this.mittKontoButton.Location = new System.Drawing.Point(32, 128);
            this.mittKontoButton.Name = "mittKontoButton";
            this.mittKontoButton.Size = new System.Drawing.Size(163, 45);
            this.mittKontoButton.TabIndex = 6;
            this.mittKontoButton.Text = "Mitt konto";
            this.mittKontoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mittKontoButton.UseVisualStyleBackColor = false;
            this.mittKontoButton.Click += new System.EventHandler(this.mittKontoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IKON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IKON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IKON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "IKON";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mina Barn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kontouppgifter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MittKontoTabControl
            // 
            this.MittKontoTabControl.Controls.Add(this.tabPage1);
            this.MittKontoTabControl.Controls.Add(this.tabPage2);
            this.MittKontoTabControl.Location = new System.Drawing.Point(193, 30);
            this.MittKontoTabControl.Name = "MittKontoTabControl";
            this.MittKontoTabControl.SelectedIndex = 0;
            this.MittKontoTabControl.Size = new System.Drawing.Size(748, 389);
            this.MittKontoTabControl.TabIndex = 21;
            this.MittKontoTabControl.Visible = false;
            // 
            // StartPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.Background1024x600;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.kontoTypLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.Name = "StartPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.informationTabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MittKontoTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kontoTypLabel;
        private System.Windows.Forms.TabControl informationTabControl;
        private System.Windows.Forms.TabPage senasteTabPage;
        private System.Windows.Forms.TabPage omTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LoggaUtLinkLabel;
        private System.Windows.Forms.Label inloggadSomNamnLabel;
        private System.Windows.Forms.Label inloggadSomLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button närvaroButton;
        private System.Windows.Forms.Button tiderButton;
        private System.Windows.Forms.Button mittKontoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl MittKontoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}