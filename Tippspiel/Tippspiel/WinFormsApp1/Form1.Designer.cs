namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radSieg = new RadioButton();
            radUnentschieden = new RadioButton();
            radNiederlage = new RadioButton();
            lblSpiel = new Label();
            numSpiel = new NumericUpDown();
            btnAuswertung = new Button();
            lblErgebnis = new Label();
            ((System.ComponentModel.ISupportInitialize)numSpiel).BeginInit();
            SuspendLayout();
            // 
            // radSieg
            // 
            radSieg.AutoSize = true;
            radSieg.Location = new Point(227, 203);
            radSieg.Margin = new Padding(5);
            radSieg.Name = "radSieg";
            radSieg.Size = new Size(91, 36);
            radSieg.TabIndex = 0;
            radSieg.TabStop = true;
            radSieg.Text = "Sieg";
            radSieg.UseVisualStyleBackColor = true;
            radSieg.CheckedChanged += radXXX_CheckedChanged;
            // 
            // radUnentschieden
            // 
            radUnentschieden.AutoSize = true;
            radUnentschieden.Location = new Point(227, 249);
            radUnentschieden.Margin = new Padding(5);
            radUnentschieden.Name = "radUnentschieden";
            radUnentschieden.Size = new Size(205, 36);
            radUnentschieden.TabIndex = 1;
            radUnentschieden.TabStop = true;
            radUnentschieden.Text = "Unentschieden";
            radUnentschieden.UseVisualStyleBackColor = true;
            radUnentschieden.CheckedChanged += radXXX_CheckedChanged;
            // 
            // radNiederlage
            // 
            radNiederlage.AutoSize = true;
            radNiederlage.Location = new Point(227, 295);
            radNiederlage.Margin = new Padding(5);
            radNiederlage.Name = "radNiederlage";
            radNiederlage.Size = new Size(162, 36);
            radNiederlage.TabIndex = 2;
            radNiederlage.TabStop = true;
            radNiederlage.Text = "Niederlage";
            radNiederlage.UseVisualStyleBackColor = true;
            radNiederlage.CheckedChanged += radXXX_CheckedChanged;
            // 
            // lblSpiel
            // 
            lblSpiel.AutoSize = true;
            lblSpiel.Location = new Point(297, 136);
            lblSpiel.Margin = new Padding(5, 0, 5, 0);
            lblSpiel.Name = "lblSpiel";
            lblSpiel.Size = new Size(78, 32);
            lblSpiel.TabIndex = 3;
            lblSpiel.Text = "label1";
            // 
            // numSpiel
            // 
            numSpiel.Location = new Point(107, 128);
            numSpiel.Margin = new Padding(5);
            numSpiel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numSpiel.Name = "numSpiel";
            numSpiel.Size = new Size(122, 39);
            numSpiel.TabIndex = 4;
            numSpiel.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnAuswertung
            // 
            btnAuswertung.Location = new Point(502, 127);
            btnAuswertung.Margin = new Padding(5);
            btnAuswertung.Name = "btnAuswertung";
            btnAuswertung.Size = new Size(151, 51);
            btnAuswertung.TabIndex = 5;
            btnAuswertung.Text = "Auswertung";
            btnAuswertung.UseVisualStyleBackColor = true;
            btnAuswertung.Click += btnAuswertung_Click;
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(517, 207);
            lblErgebnis.Margin = new Padding(5, 0, 5, 0);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(0, 32);
            lblErgebnis.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 428);
            Controls.Add(lblErgebnis);
            Controls.Add(btnAuswertung);
            Controls.Add(numSpiel);
            Controls.Add(lblSpiel);
            Controls.Add(radNiederlage);
            Controls.Add(radUnentschieden);
            Controls.Add(radSieg);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSpiel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radSieg;
        private RadioButton radUnentschieden;
        private RadioButton radNiederlage;
        private Label lblSpiel;
        private NumericUpDown numSpiel;
        private Button btnAuswertung;
        private Label lblErgebnis;
    }
}
