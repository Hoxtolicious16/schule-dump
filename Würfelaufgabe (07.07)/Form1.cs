using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfelaufgabe__07._07_
{
    public partial class Form1 : Form
    {
        int right = 0;
        int wrong = 0;
        int min = 6;
        int max = 1;
        double avg = 0;
        private int win_lose(int roll)
        {
            int roll_face = 0;
            int n_sum = 0;
            for (int i = 0; i < roll; i++)
            {
                roll_face = random.Next(1, 7);
                
                if (roll_face < min)
                {
                    min = roll_face;
                }
                if (roll_face > max)
                {
                    max = roll_face;
                }
                n_sum += roll_face;
                if (roll_face <= 3)
                {
                    MessageBox.Show("Du hast eine " + roll_face + " gewürfelt, du hast gewonnen");
                    lst_results.Items.Add(roll_face + " (Gewonnen)");
                    right ++;
                    if  (min != 0 && max != 0)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Du hast eine " + roll_face + " gewürfelt, du hast verloren");
                    lst_results.Items.Add(roll_face + " (Verloren)");
                    wrong ++;
                }
                
            }
            return n_sum;
        }
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            win_lose(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtbox_roll.Text);
            int n_sum = win_lose(n);
            double n_winrate = (double)right / (right + wrong) * 100;
            MessageBox.Show($"Du hast eine Winrate von {n_winrate:F2}%");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtbox_roll.Text);
            int n_sum = win_lose(n);
            avg = n_sum / n;
            MessageBox.Show($"Min: {min}  Max: {max} Avg: {avg:F2}");
        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }
    }
}
