using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasch
{
    public partial class Form1 : Form
    {
        int turn = 0;
        Random random = new Random();
        int player_hp = 3;
        int cpu_hp = 3;
        private void update_hearts()
        {
            PlayerHeart1.Visible = player_hp >= 1;
            PlayerHeart2.Visible = player_hp >= 2;
            PlayerHeart3.Visible = player_hp >= 3;

            CPUHeart1.Visible = cpu_hp >= 1;
            CPUHeart2.Visible = cpu_hp >= 2;
            CPUHeart3.Visible = cpu_hp >= 3;
        }

        private async Task pasch()
        {
            int pasch_wurf1 = 0;
            int pasch_wurf2 = 0;
            
            while (true)
            {
                if (player_hp <= 0)
                {
                    MessageBox.Show("Du hast Verloren!");
                    return;
                }
                else if (cpu_hp <= 0)
                {
                    MessageBox.Show("Du hast gewonnen!");
                    return;
                }
                if (turn == 0)
                    {
                        await Task.Delay(500);
                        pasch_wurf1 = random.Next(1, 7);
                        pasch_wurf2 = random.Next(1, 7);
                        if (pasch_wurf1 == pasch_wurf2)
                        {
                            lst_spieler.Items.Add($"{pasch_wurf1} und {pasch_wurf2} (Pasch)");
                            cpu_hp--;
                            update_hearts();
                            turn = 1;
                        }
                        else
                        {
                            lst_spieler.Items.Add($"{pasch_wurf1} und {pasch_wurf2}");
                            turn = 1;

                        }
                    }
                    else if (turn == 1)
                    {
                        await Task.Delay(500);
                        pasch_wurf1 = random.Next(1, 7);
                        pasch_wurf2 = random.Next(1, 7);
                        if (pasch_wurf1 == pasch_wurf2)
                        {
                            lst_cpu.Items.Add($"{pasch_wurf1} und {pasch_wurf2} (Pasch)");
                            player_hp--;
                            update_hearts();
                        turn = 0;

                        }
                        else
                        {
                            lst_cpu.Items.Add($"{pasch_wurf1} und {pasch_wurf2}");
                            turn = 0;
                        }
                    }
                }
        }
        public Form1()
        {
            InitializeComponent();
            update_hearts();
        }

        private async void spiel_starten_Click(object sender, EventArgs e)
        {
            await pasch();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PlayerHeart3_Click(object sender, EventArgs e)
        {

        }

        private void CPUHeart3_Click(object sender, EventArgs e)
        {

        }

        private void PlayerHeart2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
