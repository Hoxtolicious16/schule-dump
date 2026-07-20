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
        int dealer_total = 0;
        int player_total = 0;
        Random dice_roll = new Random();
        List<string> dealercards = new List<string>
            {
                "?", "?", "?","?","?"
            };
        List<string> playercards = new List<string>
        {
            "?", "?", "?","?","?"
        };
        public Form1()
        {
            InitializeComponent();
            lstbox_dealer.Items.AddRange(dealercards.ToArray());
            lstbox_results.Items.AddRange(playercards.ToArray());
        }

        private async Task pull_cards_dealer()
        {
            for (int i = 0; i < 5; i++)
            {
                int card = dice_roll.Next(1, 6);
                dealercards[i] = card.ToString();
                lstbox_dealer.Items[i] = dealercards[i];
                await Task.Delay(500);
            }
            int total = dealercards.Sum(card => int.Parse(card));
            lbl_sum_dealer.Text = ("Sum: " + total);
            dealer_total += total;
        }
        private async Task pull_cards_player()
        {
            for (int i = 0; i < 5; i++)
            {
                int card = dice_roll.Next(1, 6);
                playercards[i] = card.ToString();
                lstbox_results.Items[i] = playercards[i];
                await Task.Delay(500);
            }
            int total = playercards.Sum(card => int.Parse(card));
            lbl_sum_player.Text = ("Sum: " + total);
            player_total += total;
        }

        private async void btn_roll_Click(object sender, EventArgs e)
        {
            await pull_cards_player();
            await pull_cards_dealer();
            if (player_total > dealer_total) {

                MessageBox.Show("Gewonnen"); 
            }
            else if (player_total < dealer_total)
            {
                MessageBox.Show("Verloren");
            }
            else
            {
                MessageBox.Show("Unentschieden");
            }
        }

        private void lstbox_results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
