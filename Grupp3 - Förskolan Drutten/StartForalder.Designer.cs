namespace Grupp3___Förskolan_Drutten
{
    partial class StartForalder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForalder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inloggadSomNamnLabel = new System.Windows.Forms.Label();
            this.inloggadSomLabel = new System.Windows.Forms.Label();
            this.loggaBox = new System.Windows.Forms.PictureBox();
            this.kontoTypLabel = new System.Windows.Forms.Label();
            this.LoggaUtLinkLabel = new System.Windows.Forms.LinkLabel();
            this.informationButton = new System.Windows.Forms.Button();
            this.närvaroButton = new System.Windows.Forms.Button();
            this.tiderButton = new System.Windows.Forms.Button();
            this.mittKontoButton = new System.Windows.Forms.Button();
            this.informationTabControl = new System.Windows.Forms.TabControl();
            this.senasteTabPage = new System.Windows.Forms.TabPage();
            this.omTabPage = new System.Windows.Forms.TabPage();
            this.MittKontoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loggaBox)).BeginInit();
            this.informationTabControl.SuspendLayout();
            this.MittKontoTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.MittKontoTabControl);
            this.groupBox1.Controls.Add(this.informationTabControl);
            this.groupBox1.Controls.Add(this.LoggaUtLinkLabel);
            this.groupBox1.Controls.Add(this.inloggadSomNamnLabel);
            this.groupBox1.Controls.Add(this.inloggadSomLabel);
            this.groupBox1.Controls.Add(this.informationButton);
            this.groupBox1.Controls.Add(this.närvaroButton);
            this.groupBox1.Controls.Add(this.tiderButton);
            this.groupBox1.Controls.Add(this.mittKontoButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // inloggadSomNamnLabel
            // 
            this.inloggadSomNamnLabel.AutoSize = true;
            this.inloggadSomNamnLabel.Location = new System.Drawing.Point(97, 13);
            this.inloggadSomNamnLabel.Name = "inloggadSomNamnLabel";
            this.inloggadSomNamnLabel.Size = new System.Drawing.Size(85, 13);
            this.inloggadSomNamnLabel.TabIndex = 13;
            this.inloggadSomNamnLabel.Text = "(Användarnamn)";
            // 
            // inloggadSomLabel
            // 
            this.inloggadSomLabel.AutoSize = true;
            this.inloggadSomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inloggadSomLabel.Location = new System.Drawing.Point(15, 13);
            this.inloggadSomLabel.Name = "inloggadSomLabel";
            this.inloggadSomLabel.Size = new System.Drawing.Size(90, 13);
            this.inloggadSomLabel.TabIndex = 12;
            this.inloggadSomLabel.Text = "Inloggad som: ";
            // 
            // loggaBox
            // 
            this.loggaBox.Image = global::Grupp3___Förskolan_Drutten.Properties.Resources.druttenMellan;
            this.loggaBox.Location = new System.Drawing.Point(22, 12);
            this.loggaBox.Name = "loggaBox";
            this.loggaBox.Size = new System.Drawing.Size(113, 86);
            this.loggaBox.TabIndex = 1;
            this.loggaBox.TabStop = false;
            this.loggaBox.Click += new System.EventHandler(this.loggaBox_Click);
            // 
            // kontoTypLabel
            // 
            this.kontoTypLabel.AutoSize = true;
            this.kontoTypLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontoTypLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kontoTypLabel.Location = new System.Drawing.Point(141, 71);
            this.kontoTypLabel.Name = "kontoTypLabel";
            this.kontoTypLabel.Size = new System.Drawing.Size(93, 25);
            this.kontoTypLabel.TabIndex = 4;
            this.kontoTypLabel.Text = "Förälder";
            // 
            // LoggaUtLinkLabel
            // 
            this.LoggaUtLinkLabel.AutoSize = true;
            this.LoggaUtLinkLabel.Location = new System.Drawing.Point(97, 30);
            this.LoggaUtLinkLabel.Name = "LoggaUtLinkLabel";
            this.LoggaUtLinkLabel.Size = new System.Drawing.Size(49, 13);
            this.LoggaUtLinkLabel.TabIndex = 5;
            this.LoggaUtLinkLabel.TabStop = true;
            this.LoggaUtLinkLabel.Text = "Logga ut";
            this.LoggaUtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoggaUtLinkLabel_LinkClicked);
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.Color.White;
            this.informationButton.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.informationButton.FlatAppearance.BorderSize = 2;
            this.informationButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.informationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.informationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationButton.ForeColor = System.Drawing.Color.Black;
            this.informationButton.Location = new System.Drawing.Point(33, 78);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(163, 45);
            this.informationButton.TabIndex = 1;
            this.informationButton.Text = "Information";
            this.informationButton.UseVisualStyleBackColor = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // närvaroButton
            // 
            this.närvaroButton.BackColor = System.Drawing.Color.White;
            this.närvaroButton.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.närvaroButton.FlatAppearance.BorderSize = 2;
            this.närvaroButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.närvaroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.närvaroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.närvaroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.närvaroButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.närvaroButton.ForeColor = System.Drawing.Color.Black;
            this.närvaroButton.Location = new System.Drawing.Point(33, 207);
            this.närvaroButton.Name = "närvaroButton";
            this.närvaroButton.Size = new System.Drawing.Size(163, 45);
            this.närvaroButton.TabIndex = 4;
            this.närvaroButton.Text = "Närvaro";
            this.närvaroButton.UseVisualStyleBackColor = false;
            // 
            // tiderButton
            // 
            this.tiderButton.BackColor = System.Drawing.Color.White;
            this.tiderButton.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.tiderButton.FlatAppearance.BorderSize = 2;
            this.tiderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.tiderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.tiderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.tiderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiderButton.ForeColor = System.Drawing.Color.Black;
            this.tiderButton.Location = new System.Drawing.Point(33, 164);
            this.tiderButton.Name = "tiderButton";
            this.tiderButton.Size = new System.Drawing.Size(163, 45);
            this.tiderButton.TabIndex = 3;
            this.tiderButton.Text = "Tider";
            this.tiderButton.UseVisualStyleBackColor = false;
            // 
            // mittKontoButton
            // 
            this.mittKontoButton.BackColor = System.Drawing.Color.White;
            this.mittKontoButton.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.mittKontoButton.FlatAppearance.BorderSize = 2;
            this.mittKontoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.mittKontoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.mittKontoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.mittKontoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mittKontoButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mittKontoButton.ForeColor = System.Drawing.Color.Black;
            this.mittKontoButton.Location = new System.Drawing.Point(33, 121);
            this.mittKontoButton.Name = "mittKontoButton";
            this.mittKontoButton.Size = new System.Drawing.Size(163, 45);
            this.mittKontoButton.TabIndex = 2;
            this.mittKontoButton.Text = "Mitt Konto";
            this.mittKontoButton.UseVisualStyleBackColor = false;
            this.mittKontoButton.Click += new System.EventHandler(this.mittKontoButton_Click);
            // 
            // informationTabControl
            // 
            this.informationTabControl.Controls.Add(this.senasteTabPage);
            this.informationTabControl.Controls.Add(this.omTabPage);
            this.informationTabControl.Location = new System.Drawing.Point(193, 30);
            this.informationTabControl.Name = "informationTabControl";
            this.informationTabControl.SelectedIndex = 0;
            this.informationTabControl.Size = new System.Drawing.Size(748, 389);
            this.informationTabControl.TabIndex = 15;
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
            // MittKontoTabControl
            // 
            this.MittKontoTabControl.Controls.Add(this.tabPage1);
            this.MittKontoTabControl.Controls.Add(this.tabPage2);
            this.MittKontoTabControl.Location = new System.Drawing.Point(193, 30);
            this.MittKontoTabControl.Name = "MittKontoTabControl";
            this.MittKontoTabControl.SelectedIndex = 0;
            this.MittKontoTabControl.Size = new System.Drawing.Size(748, 389);
            this.MittKontoTabControl.TabIndex = 16;
            this.MittKontoTabControl.Visible = false;
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
            // StartForalder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.kontoTypLabel);
            this.Controls.Add(this.loggaBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForalder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loggaBox)).EndInit();
            this.informationTabControl.ResumeLayout(false);
            this.MittKontoTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox loggaBox;
        private System.Windows.Forms.Label inloggadSomNamnLabel;
        private System.Windows.Forms.Label inloggadSomLabel;
        private System.Windows.Forms.Label kontoTypLabel;
        private System.Windows.Forms.LinkLabel LoggaUtLinkLabel;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button närvaroButton;
        private System.Windows.Forms.Button tiderButton;
        private System.Windows.Forms.Button mittKontoButton;
        private System.Windows.Forms.TabControl informationTabControl;
        private System.Windows.Forms.TabPage senasteTabPage;
        private System.Windows.Forms.TabPage omTabPage;
        private System.Windows.Forms.TabControl MittKontoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}