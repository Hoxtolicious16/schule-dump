using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form1 : Form
    {
        int dealer_blackjack = 0;
        int blackjack = 0;
        Random dice_roll = new Random();
        public Form1()
        {
            InitializeComponent();
            lbl_result.Text = "";
        }

        private void check_winner()
        {
            if (dealer_blackjack > 21 || blackjack == 21 && dealer_blackjack > 16)
            {
                lbl_result.Text = "Gewonnen!";
                lstbox_dealer.Items.Add("Dealer busted");
                btn_roll.Enabled = false;
            }
            else if (blackjack > 21 || dealer_blackjack == 21 && blackjack != 21 || dealer_blackjack > blackjack && dealer_blackjack > 16)
            {
                lbl_result.Text = "Verloren";
                lstbox_dealer.Items.Add("Gewonnen");
                btn_roll.Enabled = false;
            }
            else if (dealer_blackjack == blackjack)
            {
                lbl_result.Text = "Tied game";
                btn_roll.Enabled = false;
            }
        }
        private void dealer_roll()
        {
            if (dealer_blackjack <= 16)
            {
                dealer_blackjack += dice_roll.Next(1, 12);
                lstbox_dealer.Items.Add(dealer_blackjack.ToString());
            }
            else
            {
                check_winner();
            }
            
        }
        private void roll()
        {
            // lstbox_results.Items.Clear();
            blackjack += dice_roll.Next(1, 12);
            lstbox_results.Items.Add(blackjack.ToString());
            if (blackjack > 21)
            {
                lstbox_results.Items.Add("Player busted");
                check_winner();
            }
        }
        private void btn_roll_Click(object sender, EventArgs e)
        {
            dealer_roll();
            roll();
        }

        private void lstbox_results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            if (dealer_blackjack <= 16)
            {
                lstbox_results.Items.Add("Stand");
                btn_roll.Enabled = false;
                dealer_roll();
                
            }
            else
            {
                check_winner();
            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
