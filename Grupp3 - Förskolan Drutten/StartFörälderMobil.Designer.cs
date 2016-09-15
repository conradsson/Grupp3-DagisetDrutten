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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFörälderMobil));
            this.menyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kontoTypLabel = new System.Windows.Forms.Label();
            this.MenyPanel = new System.Windows.Forms.Panel();
            this.menyButtonÖppnad = new System.Windows.Forms.Button();
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
            this.MenyPanel.Controls.Add(this.menyButtonÖppnad);
            this.MenyPanel.Location = new System.Drawing.Point(12, 77);
            this.MenyPanel.Name = "MenyPanel";
            this.MenyPanel.Size = new System.Drawing.Size(170, 314);
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
            // StartFörälderMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupp3___Förskolan_Drutten.Properties.Resources.Background1024x600;
            this.ClientSize = new System.Drawing.Size(339, 563);
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
    }
}