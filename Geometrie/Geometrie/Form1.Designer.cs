namespace Geometrie
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
            this.cboxForm = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblWert = new System.Windows.Forms.Label();
            this.lblUmfang = new System.Windows.Forms.Label();
            this.lblUmfangE = new System.Windows.Forms.Label();
            this.lblVolum = new System.Windows.Forms.Label();
            this.lblVolumE = new System.Windows.Forms.Label();
            this.btnAusrechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxForm
            // 
            this.cboxForm.FormattingEnabled = true;
            this.cboxForm.Items.AddRange(new object[] {
            "Dreieck",
            "Quadrat",
            "Kreis"});
            this.cboxForm.Location = new System.Drawing.Point(53, 56);
            this.cboxForm.Name = "cboxForm";
            this.cboxForm.Size = new System.Drawing.Size(192, 24);
            this.cboxForm.TabIndex = 0;
            this.cboxForm.Text = "Wähle deine Form aus";
            this.cboxForm.SelectedIndexChanged += new System.EventHandler(this.cboxForm_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblWert
            // 
            this.lblWert.AutoSize = true;
            this.lblWert.Location = new System.Drawing.Point(415, 59);
            this.lblWert.Name = "lblWert";
            this.lblWert.Size = new System.Drawing.Size(93, 16);
            this.lblWert.TabIndex = 2;
            this.lblWert.Text = "A oder Radius";
            // 
            // lblUmfang
            // 
            this.lblUmfang.AutoSize = true;
            this.lblUmfang.Location = new System.Drawing.Point(53, 130);
            this.lblUmfang.Name = "lblUmfang";
            this.lblUmfang.Size = new System.Drawing.Size(57, 16);
            this.lblUmfang.TabIndex = 3;
            this.lblUmfang.Text = "Umfang:";
            this.lblUmfang.Click += new System.EventHandler(this.lblUmfang_Click);
            // 
            // lblUmfangE
            // 
            this.lblUmfangE.AutoSize = true;
            this.lblUmfangE.Location = new System.Drawing.Point(116, 130);
            this.lblUmfangE.Name = "lblUmfangE";
            this.lblUmfangE.Size = new System.Drawing.Size(13, 16);
            this.lblUmfangE.TabIndex = 4;
            this.lblUmfangE.Text = "x";
            this.lblUmfangE.Click += new System.EventHandler(this.lblUmfangE_Click);
            // 
            // lblVolum
            // 
            this.lblVolum.AutoSize = true;
            this.lblVolum.Location = new System.Drawing.Point(53, 192);
            this.lblVolum.Name = "lblVolum";
            this.lblVolum.Size = new System.Drawing.Size(48, 16);
            this.lblVolum.TabIndex = 5;
            this.lblVolum.Text = "Volum:";
            // 
            // lblVolumE
            // 
            this.lblVolumE.AutoSize = true;
            this.lblVolumE.Location = new System.Drawing.Point(116, 192);
            this.lblVolumE.Name = "lblVolumE";
            this.lblVolumE.Size = new System.Drawing.Size(13, 16);
            this.lblVolumE.TabIndex = 6;
            this.lblVolumE.Text = "x";
            this.lblVolumE.Click += new System.EventHandler(this.lblVolumE_Click);
            // 
            // btnAusrechnen
            // 
            this.btnAusrechnen.Location = new System.Drawing.Point(309, 185);
            this.btnAusrechnen.Name = "btnAusrechnen";
            this.btnAusrechnen.Size = new System.Drawing.Size(100, 23);
            this.btnAusrechnen.TabIndex = 7;
            this.btnAusrechnen.Text = "Ausrechnen";
            this.btnAusrechnen.UseVisualStyleBackColor = true;
            this.btnAusrechnen.Click += new System.EventHandler(this.btnAusrechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAusrechnen);
            this.Controls.Add(this.lblVolumE);
            this.Controls.Add(this.lblVolum);
            this.Controls.Add(this.lblUmfangE);
            this.Controls.Add(this.lblUmfang);
            this.Controls.Add(this.lblWert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboxForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblWert;
        private System.Windows.Forms.Label lblUmfang;
        private System.Windows.Forms.Label lblUmfangE;
        private System.Windows.Forms.Label lblVolum;
        private System.Windows.Forms.Label lblVolumE;
        private System.Windows.Forms.Button btnAusrechnen;
    }
}

