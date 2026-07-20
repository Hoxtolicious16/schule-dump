namespace Gymreps
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
            this.lbl_set = new System.Windows.Forms.Label();
            this.lbl_reps = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.cbo_set = new System.Windows.Forms.ComboBox();
            this.cbo_reps = new System.Windows.Forms.ComboBox();
            this.cbo_weight = new System.Windows.Forms.ComboBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.box_results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.box_results)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.Location = new System.Drawing.Point(46, 43);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(36, 16);
            this.lbl_set.TabIndex = 0;
            this.lbl_set.Text = "Satz:";
            // 
            // lbl_reps
            // 
            this.lbl_reps.AutoSize = true;
            this.lbl_reps.Location = new System.Drawing.Point(367, 43);
            this.lbl_reps.Name = "lbl_reps";
            this.lbl_reps.Size = new System.Drawing.Size(43, 16);
            this.lbl_reps.TabIndex = 1;
            this.lbl_reps.Text = "Reps:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(46, 108);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(57, 16);
            this.lbl_weight.TabIndex = 2;
            this.lbl_weight.Text = "Gewicht:";
            // 
            // cbo_set
            // 
            this.cbo_set.FormattingEnabled = true;
            this.cbo_set.Location = new System.Drawing.Point(117, 40);
            this.cbo_set.Name = "cbo_set";
            this.cbo_set.Size = new System.Drawing.Size(121, 24);
            this.cbo_set.TabIndex = 3;
            this.cbo_set.SelectedIndexChanged += new System.EventHandler(this.cbo_set_SelectedIndexChanged);
            // 
            // cbo_reps
            // 
            this.cbo_reps.FormattingEnabled = true;
            this.cbo_reps.Location = new System.Drawing.Point(439, 40);
            this.cbo_reps.Name = "cbo_reps";
            this.cbo_reps.Size = new System.Drawing.Size(121, 24);
            this.cbo_reps.TabIndex = 4;
            this.cbo_reps.SelectedIndexChanged += new System.EventHandler(this.cbo_reps_SelectedIndexChanged);
            // 
            // cbo_weight
            // 
            this.cbo_weight.FormattingEnabled = true;
            this.cbo_weight.Location = new System.Drawing.Point(117, 108);
            this.cbo_weight.Name = "cbo_weight";
            this.cbo_weight.Size = new System.Drawing.Size(121, 24);
            this.cbo_weight.TabIndex = 5;
            this.cbo_weight.SelectedIndexChanged += new System.EventHandler(this.cbo_weight_SelectedIndexChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(439, 109);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(121, 23);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Ausrechnen";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // box_results
            // 
            this.box_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.box_results.Location = new System.Drawing.Point(117, 172);
            this.box_results.Name = "box_results";
            this.box_results.RowHeadersWidth = 51;
            this.box_results.RowTemplate.Height = 24;
            this.box_results.Size = new System.Drawing.Size(443, 244);
            this.box_results.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_results);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.cbo_weight);
            this.Controls.Add(this.cbo_reps);
            this.Controls.Add(this.cbo_set);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_reps);
            this.Controls.Add(this.lbl_set);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.box_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.Label lbl_reps;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.ComboBox cbo_set;
        private System.Windows.Forms.ComboBox cbo_reps;
        private System.Windows.Forms.ComboBox cbo_weight;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView box_results;
    }
}

