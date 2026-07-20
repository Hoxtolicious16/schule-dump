namespace Geburtstagguesser
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
            lbl_zahl = new Label();
            cmb_zahl = new ComboBox();
            lbl_geburtsjahr = new Label();
            txt_geburtsjahr = new TextBox();
            lbl_geburtstag = new Label();
            btn_ausrechnen = new Button();
            radiobtn_nein = new RadioButton();
            radiobtn_ja = new RadioButton();
            lbl_deinezahl = new Label();
            lbl_deinezahl1 = new Label();
            SuspendLayout();
            // 
            // lbl_zahl
            // 
            lbl_zahl.AutoSize = true;
            lbl_zahl.Location = new Point(81, 53);
            lbl_zahl.Name = "lbl_zahl";
            lbl_zahl.Size = new Size(38, 20);
            lbl_zahl.TabIndex = 0;
            lbl_zahl.Text = "Zahl";
            lbl_zahl.Click += label1_Click;
            // 
            // cmb_zahl
            // 
            cmb_zahl.FormattingEnabled = true;
            cmb_zahl.Location = new Point(241, 45);
            cmb_zahl.MaxDropDownItems = 7;
            cmb_zahl.Name = "cmb_zahl";
            cmb_zahl.Size = new Size(151, 28);
            cmb_zahl.TabIndex = 1;
            cmb_zahl.SelectedIndexChanged += cmb_zahl_SelectedIndexChanged;
            // 
            // lbl_geburtsjahr
            // 
            lbl_geburtsjahr.AutoSize = true;
            lbl_geburtsjahr.Location = new Point(81, 136);
            lbl_geburtsjahr.Name = "lbl_geburtsjahr";
            lbl_geburtsjahr.Size = new Size(85, 20);
            lbl_geburtsjahr.TabIndex = 2;
            lbl_geburtsjahr.Text = "Geburtsjahr";
            // 
            // txt_geburtsjahr
            // 
            txt_geburtsjahr.Location = new Point(241, 129);
            txt_geburtsjahr.Name = "txt_geburtsjahr";
            txt_geburtsjahr.PlaceholderText = "z.B 2001";
            txt_geburtsjahr.Size = new Size(125, 27);
            txt_geburtsjahr.TabIndex = 3;
            txt_geburtsjahr.TextChanged += txt_geburtsjahr_TextChanged;
            // 
            // lbl_geburtstag
            // 
            lbl_geburtstag.AutoSize = true;
            lbl_geburtstag.Location = new Point(81, 224);
            lbl_geburtstag.Name = "lbl_geburtstag";
            lbl_geburtstag.Size = new Size(140, 20);
            lbl_geburtstag.TabIndex = 6;
            lbl_geburtstag.Text = "Geburtstag gehabt?";
            // 
            // btn_ausrechnen
            // 
            btn_ausrechnen.Location = new Point(241, 337);
            btn_ausrechnen.Name = "btn_ausrechnen";
            btn_ausrechnen.Size = new Size(94, 29);
            btn_ausrechnen.TabIndex = 7;
            btn_ausrechnen.Text = "Ausrechnen";
            btn_ausrechnen.UseVisualStyleBackColor = true;
            btn_ausrechnen.Click += btn_ausrechnen_Click;
            // 
            // radiobtn_nein
            // 
            radiobtn_nein.AutoSize = true;
            radiobtn_nein.Location = new Point(331, 220);
            radiobtn_nein.Name = "radiobtn_nein";
            radiobtn_nein.Size = new Size(61, 24);
            radiobtn_nein.TabIndex = 5;
            radiobtn_nein.TabStop = true;
            radiobtn_nein.Text = "Nein";
            radiobtn_nein.UseVisualStyleBackColor = true;
            radiobtn_nein.CheckedChanged += radiobtn_nein_CheckedChanged;
            // 
            // radiobtn_ja
            // 
            radiobtn_ja.AutoSize = true;
            radiobtn_ja.Location = new Point(241, 220);
            radiobtn_ja.Name = "radiobtn_ja";
            radiobtn_ja.Size = new Size(43, 24);
            radiobtn_ja.TabIndex = 4;
            radiobtn_ja.TabStop = true;
            radiobtn_ja.Text = "Ja";
            radiobtn_ja.UseVisualStyleBackColor = true;
            radiobtn_ja.CheckedChanged += radiobtn_ja_CheckedChanged;
            // 
            // lbl_deinezahl
            // 
            lbl_deinezahl.AutoSize = true;
            lbl_deinezahl.Location = new Point(81, 287);
            lbl_deinezahl.Name = "lbl_deinezahl";
            lbl_deinezahl.Size = new Size(84, 20);
            lbl_deinezahl.TabIndex = 8;
            lbl_deinezahl.Text = "Deine Zahl:";
            // 
            // lbl_deinezahl1
            // 
            lbl_deinezahl1.AutoSize = true;
            lbl_deinezahl1.Location = new Point(244, 290);
            lbl_deinezahl1.Name = "lbl_deinezahl1";
            lbl_deinezahl1.Size = new Size(17, 20);
            lbl_deinezahl1.TabIndex = 9;
            lbl_deinezahl1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_deinezahl1);
            Controls.Add(lbl_deinezahl);
            Controls.Add(btn_ausrechnen);
            Controls.Add(lbl_geburtstag);
            Controls.Add(radiobtn_nein);
            Controls.Add(radiobtn_ja);
            Controls.Add(txt_geburtsjahr);
            Controls.Add(lbl_geburtsjahr);
            Controls.Add(cmb_zahl);
            Controls.Add(lbl_zahl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_zahl;
        private ComboBox cmb_zahl;
        private Label lbl_geburtsjahr;
        private TextBox txt_geburtsjahr;
        private Label lbl_geburtstag;
        private Button btn_ausrechnen;
        private RadioButton radiobtn_nein;
        private RadioButton radiobtn_ja;
        private Label lbl_deinezahl;
        private Label lbl_deinezahl1;
    }
}
