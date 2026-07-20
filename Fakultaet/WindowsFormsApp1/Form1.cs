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
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_zahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_fak_Click(object sender, EventArgs e)
        {

        }

        private void btn_ausrechnen_Click(object sender, EventArgs e)
        {
            lbl_fak.Text = "Fakultät";
            int zahl = Int32.Parse(txt_zahl.Text);
            long fak = 1;
            for (int i = 1; i <= zahl; i++)
            {
                fak *= i;
                lbl_fak.Text += Environment.NewLine + fak.ToString();
            }
                
        }
    }
}
