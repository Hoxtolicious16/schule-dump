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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtdp1 = new System.Windows.Forms.TextBox();
            this.txtdp2 = new System.Windows.Forms.TextBox();
            this.txtpp1 = new System.Windows.Forms.TextBox();
            this.txtpp2 = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lbldp1 = new System.Windows.Forms.Label();
            this.lbldp2 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ausrechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdp1
            // 
            this.txtdp1.Location = new System.Drawing.Point(128, 92);
            this.txtdp1.Name = "txtdp1";
            this.txtdp1.Size = new System.Drawing.Size(100, 22);
            this.txtdp1.TabIndex = 1;
            this.txtdp1.TextChanged += new System.EventHandler(this.txtdp1_TextChanged);
            // 
            // txtdp2
            // 
            this.txtdp2.Location = new System.Drawing.Point(128, 146);
            this.txtdp2.Name = "txtdp2";
            this.txtdp2.Size = new System.Drawing.Size(100, 22);
            this.txtdp2.TabIndex = 2;
            // 
            // txtpp1
            // 
            this.txtpp1.Location = new System.Drawing.Point(596, 92);
            this.txtpp1.Name = "txtpp1";
            this.txtpp1.Size = new System.Drawing.Size(100, 22);
            this.txtpp1.TabIndex = 3;
            this.txtpp1.TextChanged += new System.EventHandler(this.txtpp1_TextChanged);
            // 
            // txtpp2
            // 
            this.txtpp2.Location = new System.Drawing.Point(596, 146);
            this.txtpp2.Name = "txtpp2";
            this.txtpp2.Size = new System.Drawing.Size(100, 22);
            this.txtpp2.TabIndex = 4;
            this.txtpp2.TextChanged += new System.EventHandler(this.txtpp2_TextChanged);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(101, 54);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(156, 16);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "Pizza Durchschnitt (in cm)";
            // 
            // lbldp1
            // 
            this.lbldp1.AutoSize = true;
            this.lbldp1.Location = new System.Drawing.Point(48, 98);
            this.lbldp1.Name = "lbldp1";
            this.lbldp1.Size = new System.Drawing.Size(49, 16);
            this.lbldp1.TabIndex = 6;
            this.lbldp1.Text = "Pizza 1";
            // 
            // lbldp2
            // 
            this.lbldp2.AutoSize = true;
            this.lbldp2.Location = new System.Drawing.Point(48, 152);
            this.lbldp2.Name = "lbldp2";
            this.lbldp2.Size = new System.Drawing.Size(49, 16);
            this.lbldp2.TabIndex = 7;
            this.lbldp2.Text = "Pizza 2";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(607, 54);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(69, 16);
            this.lblP.TabIndex = 8;
            this.lblP.Text = "Preis (in €)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(372, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "€ pro cm";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(401, 315);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 16);
            this.lblResult1.TabIndex = 10;
            this.lblResult1.Click += new System.EventHandler(this.lblResult1_Click);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(301, 315);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(49, 16);
            this.lblP1.TabIndex = 11;
            this.lblP1.Text = "Pizza 1";
            this.lblP1.Click += new System.EventHandler(this.lblP1_Click);
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(301, 351);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(49, 16);
            this.lblP2.TabIndex = 12;
            this.lblP2.Text = "Pizza 2";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(401, 351);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 16);
            this.lblResult2.TabIndex = 13;
            this.lblResult2.Click += new System.EventHandler(this.lblResult2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lbldp2);
            this.Controls.Add(this.lbldp1);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtpp2);
            this.Controls.Add(this.txtpp1);
            this.Controls.Add(this.txtdp2);
            this.Controls.Add(this.txtdp1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdp1;
        private System.Windows.Forms.TextBox txtdp2;
        private System.Windows.Forms.TextBox txtpp1;
        private System.Windows.Forms.TextBox txtpp2;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lbldp1;
        private System.Windows.Forms.Label lbldp2;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

