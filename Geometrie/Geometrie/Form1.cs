using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboxForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUmfang_Click(object sender, EventArgs e)
        {

        }

        private void lblUmfangE_Click(object sender, EventArgs e)
        {

        }

        private void lblVolumE_Click(object sender, EventArgs e)
        {

        }
        double AusrechnenU(double Wert, string art)
        {
            if (art == "Dreieck")
            {
                return Wert * 3;
            }

            if (art == "Quadrat")
            {
                return Wert * 4;
            }
            if (art == "Kreis")
            {
                return Math.Round(2 * Math.PI * Wert, 2);
            }
            if (art == null)
            {
                return 0;
            }
            return 0;
        }
        double AusrechnenA(double Wert, string art)
        {
            if (art == "Dreieck")
            {
                return Math.Sqrt(Math.Pow(Wert, 2) - Math.Pow(Wert / 2, 2)) * (Wert / 2);
            }

            if (art == "Quadrat")
            {
                return Math.Pow(Wert, 2);
            }
            if (art == "Kreis")
            {
                return Math.Round(Math.PI * Math.Pow(Wert, 2), 2);
            }
            return 0;
        }
        private void btnAusrechnen_Click(object sender, EventArgs e)
        {
            if (cboxForm.SelectedIndex != -1 || textBox1 != null)
            {
                lblUmfangE.Text = AusrechnenU(Convert.ToDouble(textBox1.Text), cboxForm.SelectedItem.ToString()).ToString();
                lblVolumE.Text = AusrechnenA(Convert.ToDouble(textBox1.Text), cboxForm.SelectedItem.ToString()).ToString();
            }
            else
            {
                MessageBox.Show("Bitte eine Form oder einen Wert eingeben");
            }
        }
    }
}