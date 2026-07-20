namespace Pasch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_spieler = new System.Windows.Forms.ListBox();
            this.lst_cpu = new System.Windows.Forms.ListBox();
            this.spiel_starten = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.PlayerHeart1 = new System.Windows.Forms.PictureBox();
            this.PlayerHeart2 = new System.Windows.Forms.PictureBox();
            this.PlayerHeart3 = new System.Windows.Forms.PictureBox();
            this.CPUHeart3 = new System.Windows.Forms.PictureBox();
            this.CPUHeart2 = new System.Windows.Forms.PictureBox();
            this.CPUHeart1 = new System.Windows.Forms.PictureBox();
            this.lblSpieler = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_spieler
            // 
            this.lst_spieler.FormattingEnabled = true;
            this.lst_spieler.ItemHeight = 16;
            this.lst_spieler.Location = new System.Drawing.Point(119, 66);
            this.lst_spieler.Name = "lst_spieler";
            this.lst_spieler.Size = new System.Drawing.Size(120, 324);
            this.lst_spieler.TabIndex = 0;
            // 
            // lst_cpu
            // 
            this.lst_cpu.FormattingEnabled = true;
            this.lst_cpu.ItemHeight = 16;
            this.lst_cpu.Location = new System.Drawing.Point(533, 66);
            this.lst_cpu.Name = "lst_cpu";
            this.lst_cpu.Size = new System.Drawing.Size(131, 324);
            this.lst_cpu.TabIndex = 1;
            // 
            // spiel_starten
            // 
            this.spiel_starten.Location = new System.Drawing.Point(354, 66);
            this.spiel_starten.Name = "spiel_starten";
            this.spiel_starten.Size = new System.Drawing.Size(75, 23);
            this.spiel_starten.TabIndex = 2;
            this.spiel_starten.Text = "Spielen";
            this.spiel_starten.UseVisualStyleBackColor = true;
            this.spiel_starten.Click += new System.EventHandler(this.spiel_starten_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(354, 109);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // PlayerHeart1
            // 
            this.PlayerHeart1.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.PlayerHeart1.Location = new System.Drawing.Point(119, 12);
            this.PlayerHeart1.Name = "PlayerHeart1";
            this.PlayerHeart1.Size = new System.Drawing.Size(39, 27);
            this.PlayerHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerHeart1.TabIndex = 6;
            this.PlayerHeart1.TabStop = false;
            // 
            // PlayerHeart2
            // 
            this.PlayerHeart2.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.PlayerHeart2.Location = new System.Drawing.Point(163, 12);
            this.PlayerHeart2.Name = "PlayerHeart2";
            this.PlayerHeart2.Size = new System.Drawing.Size(36, 26);
            this.PlayerHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerHeart2.TabIndex = 7;
            this.PlayerHeart2.TabStop = false;
            this.PlayerHeart2.Click += new System.EventHandler(this.PlayerHeart2_Click);
            // 
            // PlayerHeart3
            // 
            this.PlayerHeart3.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.PlayerHeart3.Location = new System.Drawing.Point(205, 11);
            this.PlayerHeart3.Name = "PlayerHeart3";
            this.PlayerHeart3.Size = new System.Drawing.Size(34, 27);
            this.PlayerHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerHeart3.TabIndex = 8;
            this.PlayerHeart3.TabStop = false;
            this.PlayerHeart3.Click += new System.EventHandler(this.PlayerHeart3_Click);
            // 
            // CPUHeart3
            // 
            this.CPUHeart3.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.CPUHeart3.Location = new System.Drawing.Point(624, 10);
            this.CPUHeart3.Name = "CPUHeart3";
            this.CPUHeart3.Size = new System.Drawing.Size(40, 28);
            this.CPUHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUHeart3.TabIndex = 11;
            this.CPUHeart3.TabStop = false;
            this.CPUHeart3.Click += new System.EventHandler(this.CPUHeart3_Click);
            // 
            // CPUHeart2
            // 
            this.CPUHeart2.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.CPUHeart2.Location = new System.Drawing.Point(580, 10);
            this.CPUHeart2.Name = "CPUHeart2";
            this.CPUHeart2.Size = new System.Drawing.Size(41, 28);
            this.CPUHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUHeart2.TabIndex = 10;
            this.CPUHeart2.TabStop = false;
            // 
            // CPUHeart1
            // 
            this.CPUHeart1.Image = global::Pasch.Properties.Resources._306_3066830_heart_game_icon_png_transparent_png;
            this.CPUHeart1.Location = new System.Drawing.Point(533, 10);
            this.CPUHeart1.Name = "CPUHeart1";
            this.CPUHeart1.Size = new System.Drawing.Size(44, 28);
            this.CPUHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUHeart1.TabIndex = 9;
            this.CPUHeart1.TabStop = false;
            // 
            // lblSpieler
            // 
            this.lblSpieler.AutoSize = true;
            this.lblSpieler.Location = new System.Drawing.Point(149, 47);
            this.lblSpieler.Name = "lblSpieler";
            this.lblSpieler.Size = new System.Drawing.Size(50, 16);
            this.lblSpieler.TabIndex = 12;
            this.lblSpieler.Text = "Spieler";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(577, 47);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(35, 16);
            this.lblCPU.TabIndex = 13;
            this.lblCPU.Text = "CPU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblSpieler);
            this.Controls.Add(this.CPUHeart3);
            this.Controls.Add(this.CPUHeart2);
            this.Controls.Add(this.CPUHeart1);
            this.Controls.Add(this.PlayerHeart3);
            this.Controls.Add(this.PlayerHeart2);
            this.Controls.Add(this.PlayerHeart1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.spiel_starten);
            this.Controls.Add(this.lst_cpu);
            this.Controls.Add(this.lst_spieler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUHeart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_spieler;
        private System.Windows.Forms.ListBox lst_cpu;
        private System.Windows.Forms.Button spiel_starten;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox PlayerHeart1;
        private System.Windows.Forms.PictureBox PlayerHeart2;
        private System.Windows.Forms.PictureBox PlayerHeart3;
        private System.Windows.Forms.PictureBox CPUHeart3;
        private System.Windows.Forms.PictureBox CPUHeart2;
        private System.Windows.Forms.PictureBox CPUHeart1;
        private System.Windows.Forms.Label lblSpieler;
        private System.Windows.Forms.Label lblCPU;
    }
}

