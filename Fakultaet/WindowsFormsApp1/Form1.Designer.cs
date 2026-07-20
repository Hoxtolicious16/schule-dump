namespace WindowsFormsApp1
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
            this.txt_zahl = new System.Windows.Forms.TextBox();
            this.btn_ausrechnen = new System.Windows.Forms.Button();
            this.lbl_fak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_zahl
            // 
            this.txt_zahl.Location = new System.Drawing.Point(196, 48);
            this.txt_zahl.Name = "txt_zahl";
            this.txt_zahl.Size = new System.Drawing.Size(100, 22);
            this.txt_zahl.TabIndex = 0;
            this.txt_zahl.TextChanged += new System.EventHandler(this.txt_zahl_TextChanged);
            // 
            // btn_ausrechnen
            // 
            this.btn_ausrechnen.Location = new System.Drawing.Point(196, 415);
            this.btn_ausrechnen.Name = "btn_ausrechnen";
            this.btn_ausrechnen.Size = new System.Drawing.Size(100, 23);
            this.btn_ausrechnen.TabIndex = 1;
            this.btn_ausrechnen.Text = "Ausrechnen";
            this.btn_ausrechnen.UseVisualStyleBackColor = true;
            this.btn_ausrechnen.Click += new System.EventHandler(this.btn_ausrechnen_Click);
            // 
            // lbl_fak
            // 
            this.lbl_fak.AutoSize = true;
            this.lbl_fak.Location = new System.Drawing.Point(216, 73);
            this.lbl_fak.Name = "lbl_fak";
            this.lbl_fak.Size = new System.Drawing.Size(57, 16);
            this.lbl_fak.TabIndex = 2;
            this.lbl_fak.Text = "Fakultät:";
            this.lbl_fak.Click += new System.EventHandler(this.lbl_fak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_fak);
            this.Controls.Add(this.btn_ausrechnen);
            this.Controls.Add(this.txt_zahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_zahl;
        private System.Windows.Forms.Button btn_ausrechnen;
        private System.Windows.Forms.Label lbl_fak;
    }
}

