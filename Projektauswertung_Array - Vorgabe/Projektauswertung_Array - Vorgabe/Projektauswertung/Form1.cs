using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektauswertung
{
    public partial class Form1 : Form
    {
        string[] Schueler = { "Hans", "Anja", "Klaus" };
        string[,] Praktikanten = new string[3, 5];
        public Form1()
        {
            InitializeComponent();

            //Notenvorgabe für einige Praktikanten
            Praktikanten[0, 1] = "4";
            Praktikanten[0, 2] = "3";
            Praktikanten[1, 1] = "1";
            Praktikanten[1, 2] = "3";
            Praktikanten[1, 3] = "2";
            Praktikanten[1, 4] = "3";
            cboPersonen.Items.AddRange(Schueler);

        }

 private void cboPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstNoten.Items.Clear();
            if (Praktikanten[cboPersonen.SelectedIndex, Praktikanten.GetLength(1) - 1] != null)
            {
                btnNote.Enabled = false;
            }
            else
            {
                btnNote.Enabled = true;
            }
            for (int i = 0; i < Praktikanten.GetLength(1); i++)
            {
                if (Praktikanten[cboPersonen.SelectedIndex, i] != null)
                {
                    LstNoten.Items.Add(Praktikanten[cboPersonen.SelectedIndex, i]);
                }
            }
        }



        private void btnNote_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Praktikanten.GetLength(1) - 1; i++)
            {
                if (Praktikanten[cboPersonen.SelectedIndex, i] == null)
                {
                    Praktikanten[cboPersonen.SelectedIndex, i] = txtNote.Text.ToString();
                    Praktikanten[cboPersonen.SelectedIndex, Praktikanten.GetLength(1) - 1] = txtNote.Text.ToString();
                    cboPersonen_SelectedIndexChanged(null, null);
                    break;
                }
            }

        }
       
    }
}
