using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   double pizza1;
        double pizza2;
        Label lblGewinner = new Label();
        
        public Form1()
        {
            InitializeComponent();
            lblGewinner.Text = "Gewinner!";
            lblGewinner.Visible = false;
            this.Controls.Add(lblGewinner);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtdp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtdp1.Text) || string.IsNullOrEmpty(txtdp2.Text) || string.IsNullOrEmpty(txtpp1.Text) || string.IsNullOrEmpty(txtpp2.Text))
                {
                    MessageBox.Show("Bitte eine Zahl eingeben");
                    return;

                }
                if (!double.TryParse(txtdp1.Text,out double dp1)||
                !double.TryParse(txtdp2.Text, out double dp2)||
                !double.TryParse(txtpp1.Text, out double pp1)||
                !double.TryParse(txtpp2.Text, out double pp2)) { 
                    MessageBox.Show("Bitte eine gültige Zahl eingeben");
                    return;
                }

                pizza1 = Math.Round(pp1/(Math.Pow(dp1 / 2, 2) * Math.PI),4,MidpointRounding.AwayFromZero);
                pizza2 = Math.Round(pp2/(Math.Pow(dp2 / 2,2) * Math.PI),4,MidpointRounding.AwayFromZero);
                lblResult1.Text = pizza1 + "€";
                lblResult2.Text = pizza2 + "€";
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (txtdp1.Text == "67"||txtdp2.Text == "67")
                    {
                    MessageBox.Show("67777777");
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (pizza1 >= pizza2)
            {
                lblGewinner.Visible = false;
                lblResult2.ForeColor = Color.Black;
                lblResult1.ForeColor = Color.Green;
                lblGewinner.Location = new Point(401, 255);
                lblGewinner.Visible = true;
            }
            else
            {
                lblGewinner.Visible = false;
                lblResult1.ForeColor = Color.Black;
                lblResult2.ForeColor = Color.Green;
                lblGewinner.Location = new Point(401, 285);
                lblGewinner.Visible = true;
            }
        }

        private void txtpp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult1_Click(object sender, EventArgs e)
        {

        }

        private void lblResult2_Click(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {
        }
    }
}
