namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            radSieg = new Guna.UI2.WinForms.Guna2RadioButton();
            radUnentschieden = new Guna.UI2.WinForms.Guna2RadioButton();
            radNiederlage = new Guna.UI2.WinForms.Guna2RadioButton();
            lblSpiel = new Label();
            numSpiel = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btnAuswertung = new Guna.UI2.WinForms.Guna2Button();
            lblErgebnis = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)numSpiel).BeginInit();
            SuspendLayout();
            // 
            // radSieg
            // 
            radSieg.AutoSize = true;
            radSieg.CheckedState.BorderThickness = 0;
            radSieg.Location = new Point(140, 127);
            radSieg.Margin = new Padding(2);
            radSieg.Name = "radSieg";
            radSieg.Size = new Size(59, 24);
            radSieg.TabIndex = 0;
            radSieg.Text = "Sieg";
            radSieg.UncheckedState.BorderThickness = 0;
            radSieg.CheckedChanged += radXXX_CheckedChanged;
            // 
            // radUnentschieden
            // 
            radUnentschieden.AutoSize = true;
            radUnentschieden.CheckedState.BorderThickness = 0;
            radUnentschieden.Location = new Point(140, 156);
            radUnentschieden.Margin = new Padding(2);
            radUnentschieden.Name = "radUnentschieden";
            radUnentschieden.Size = new Size(127, 24);
            radUnentschieden.TabIndex = 1;
            radUnentschieden.Text = "Unentschieden";
            radUnentschieden.UncheckedState.BorderThickness = 0;
            radUnentschieden.CheckedChanged += radXXX_CheckedChanged;
            // 
            // radNiederlage
            // 
            radNiederlage.AutoSize = true;
            radNiederlage.CheckedState.BorderThickness = 0;
            radNiederlage.Location = new Point(140, 184);
            radNiederlage.Margin = new Padding(2);
            radNiederlage.Name = "radNiederlage";
            radNiederlage.Size = new Size(104, 24);
            radNiederlage.TabIndex = 2;
            radNiederlage.Text = "Niederlage";
            radNiederlage.UncheckedState.BorderThickness = 0;
            radNiederlage.CheckedChanged += radXXX_CheckedChanged;
            // 
            // lblSpiel
            // 
            lblSpiel.AutoSize = true;
            lblSpiel.Location = new Point(183, 85);
            lblSpiel.Margin = new Padding(2, 0, 2, 0);
            lblSpiel.Name = "lblSpiel";
            lblSpiel.Size = new Size(50, 20);
            lblSpiel.TabIndex = 3;
            lblSpiel.Text = "label1";
            // 
            // numSpiel
            // 
            numSpiel.BackColor = Color.Transparent;
            numSpiel.CustomizableEdges = customizableEdges1;
            numSpiel.Font = new Font("Segoe UI", 9F);
            numSpiel.Location = new Point(66, 80);
            numSpiel.Margin = new Padding(2);
            numSpiel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numSpiel.Name = "numSpiel";
            numSpiel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            numSpiel.Size = new Size(75, 24);
            numSpiel.TabIndex = 4;
            numSpiel.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnAuswertung
            // 
            btnAuswertung.CustomizableEdges = customizableEdges3;
            btnAuswertung.Font = new Font("Segoe UI", 9F);
            btnAuswertung.ForeColor = Color.White;
            btnAuswertung.Location = new Point(309, 79);
            btnAuswertung.Margin = new Padding(2);
            btnAuswertung.Name = "btnAuswertung";
            btnAuswertung.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAuswertung.Size = new Size(133, 32);
            btnAuswertung.TabIndex = 5;
            btnAuswertung.Text = "Auswertung";
            btnAuswertung.Click += btnAuswertung_Click;
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Location = new Point(318, 129);
            lblErgebnis.Margin = new Padding(2, 0, 2, 0);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(0, 20);
            lblErgebnis.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(674, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 7;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 268);
            Controls.Add(guna2ControlBox1);
            Controls.Add(lblErgebnis);
            Controls.Add(btnAuswertung);
            Controls.Add(numSpiel);
            Controls.Add(lblSpiel);
            Controls.Add(radNiederlage);
            Controls.Add(radUnentschieden);
            Controls.Add(radSieg);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSpiel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton radSieg;
        private Guna.UI2.WinForms.Guna2RadioButton radUnentschieden;
        private Guna.UI2.WinForms.Guna2RadioButton radNiederlage;
        private System.Windows.Forms.Label lblSpiel;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSpiel;
        private Guna.UI2.WinForms.Guna2Button btnAuswertung;
        private System.Windows.Forms.Label lblErgebnis;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}