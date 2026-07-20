using System.Threading.Tasks;

namespace blackjack
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
        private async Task InitializeComponent()
        {
            this.btn_roll = new System.Windows.Forms.Button();
            this.lstbox_results = new System.Windows.Forms.ListBox();
            this.lstbox_dealer = new System.Windows.Forms.ListBox();
            this.lbl_dealer = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_stand = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_sum_dealer = new System.Windows.Forms.Label();
            this.lbl_sum_player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(149, 234);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(75, 23);
            this.btn_roll.TabIndex = 0;
            this.btn_roll.Text = "Hit";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // lstbox_results
            // 
            this.lstbox_results.FormattingEnabled = true;
            this.lstbox_results.ItemHeight = 16;
            this.lstbox_results.Location = new System.Drawing.Point(149, 90);
            this.lstbox_results.Name = "lstbox_results";
            this.lstbox_results.Size = new System.Drawing.Size(208, 100);
            this.lstbox_results.TabIndex = 1;
            this.lstbox_results.SelectedIndexChanged += new System.EventHandler(this.lstbox_results_SelectedIndexChanged);
            // 
            // lstbox_dealer
            // 
            this.lstbox_dealer.FormattingEnabled = true;
            this.lstbox_dealer.ItemHeight = 16;
            this.lstbox_dealer.Location = new System.Drawing.Point(504, 90);
            this.lstbox_dealer.Name = "lstbox_dealer";
            this.lstbox_dealer.Size = new System.Drawing.Size(208, 100);
            this.lstbox_dealer.TabIndex = 2;
            // 
            // lbl_dealer
            // 
            this.lbl_dealer.AutoSize = true;
            this.lbl_dealer.Location = new System.Drawing.Point(565, 39);
            this.lbl_dealer.Name = "lbl_dealer";
            this.lbl_dealer.Size = new System.Drawing.Size(87, 16);
            this.lbl_dealer.TabIndex = 3;
            this.lbl_dealer.Text = "Dealer (CPU)";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(357, 208);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 16);
            this.lbl_result.TabIndex = 4;
            // 
            // btn_stand
            // 
            this.btn_stand.Location = new System.Drawing.Point(287, 234);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(70, 23);
            this.btn_stand.TabIndex = 5;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(394, 167);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_sum_dealer
            // 
            this.lbl_sum_dealer.AutoSize = true;
            this.lbl_sum_dealer.Location = new System.Drawing.Point(504, 197);
            this.lbl_sum_dealer.Name = "lbl_sum_dealer";
            this.lbl_sum_dealer.Size = new System.Drawing.Size(0, 16);
            this.lbl_sum_dealer.TabIndex = 7;
            // 
            // lbl_sum_player
            // 
            this.lbl_sum_player.AutoSize = true;
            this.lbl_sum_player.Location = new System.Drawing.Point(146, 197);
            this.lbl_sum_player.Name = "lbl_sum_player";
            this.lbl_sum_player.Size = new System.Drawing.Size(0, 16);
            this.lbl_sum_player.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sum_player);
            this.Controls.Add(this.lbl_sum_dealer);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_dealer);
            this.Controls.Add(this.lstbox_dealer);
            this.Controls.Add(this.lstbox_results);
            this.Controls.Add(this.btn_roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.ListBox lstbox_results;
        private System.Windows.Forms.ListBox lstbox_dealer;
        private System.Windows.Forms.Label lbl_dealer;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_sum_dealer;
        private System.Windows.Forms.Label lbl_sum_player;
    }
}

