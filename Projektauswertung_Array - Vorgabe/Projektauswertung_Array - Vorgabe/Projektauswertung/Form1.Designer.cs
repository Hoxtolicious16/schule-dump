
namespace Projektauswertung
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
            this.LstNoten = new System.Windows.Forms.ListBox();
            this.cboPersonen = new System.Windows.Forms.ComboBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstNoten
            // 
            this.LstNoten.FormattingEnabled = true;
            this.LstNoten.Location = new System.Drawing.Point(112, 96);
            this.LstNoten.Margin = new System.Windows.Forms.Padding(2);
            this.LstNoten.Name = "LstNoten";
            this.LstNoten.Size = new System.Drawing.Size(212, 95);
            this.LstNoten.TabIndex = 0;
            // 
            // cboPersonen
            // 
            this.cboPersonen.FormattingEnabled = true;
            this.cboPersonen.Location = new System.Drawing.Point(112, 47);
            this.cboPersonen.Margin = new System.Windows.Forms.Padding(2);
            this.cboPersonen.Name = "cboPersonen";
            this.cboPersonen.Size = new System.Drawing.Size(212, 21);
            this.cboPersonen.TabIndex = 1;
            this.cboPersonen.SelectedIndexChanged += new System.EventHandler(this.cboPersonen_SelectedIndexChanged);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(115, 222);
            this.lblAusgabe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
            this.lblAusgabe.TabIndex = 2;
            this.lblAusgabe.Text = "label1";
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(239, 281);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(85, 21);
            this.btnNote.TabIndex = 3;
            this.btnNote.Text = "Note eintragen";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(112, 282);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 20);
            this.txtNote.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.cboPersonen);
            this.Controls.Add(this.LstNoten);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstNoten;
        private System.Windows.Forms.ComboBox cboPersonen;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.TextBox txtNote;
    }
}

