namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] Spiele = new string[4];
        int[] Tipps = new int[4];
        string[] Ergebisse = new string[4];

        public Form1()
        {
            InitializeComponent();
            numSpiel.Value = 1;
            numSpiel.Value = 0;
            Spiele[0] = "Gruppe E";
            Spiele[1] = "GER-CUR";
            Spiele[2] = "GER-CIV";
            Spiele[3] = "GER-ECU";

            radSieg.Checked = false;
            radUnentschieden.Checked = false;
            radNiederlage.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int wert = (int)numSpiel.Value;
            lblSpiel.Text = Spiele[wert];


            switch (Tipps[wert])
            {
                case 0:
                    radSieg.Checked = false;
                    radUnentschieden.Checked = false;
                    radNiederlage.Checked = false;
                    break;
                case 1:
                    radSieg.Checked = true;
                    break;
                case 2:
                    radUnentschieden.Checked = true;
                    break;
                case 3:
                    radNiederlage.Checked = true;
                    break;
            }
            /*foreach (int tipp in Tipps)       hat nicht geklappt, bin zu switch gewechselt
            {
                if (tipp != 0)
                    if (Tipps[tipp] == 1)
                    {
                        radSieg.Checked = true;
                    }
                    if (Tipps[tipp] == 2)
                    {
                        radUnentschieden.Checked = true;
                    }
                    if (Tipps[tipp] == 3)
                    {
                        radNiederlage.Checked = true;
                    }
                    else
                    {
                        radNiederlage.Checked = false;
                        radSieg.Checked = false;
                        radUnentschieden.Checked = false;
                    }
            }*/
        }

        private void radXXX_CheckedChanged(object sender, EventArgs e)
        {
            if (radSieg.Checked)
            {
                Tipps[(int)numSpiel.Value] = 1;
            }
            else if (radUnentschieden.Checked)
            {
                Tipps[(int)numSpiel.Value] = 2;
            }
            else if (radNiederlage.Checked)
            {
                Tipps[(int)numSpiel.Value] = 3;
            }
        }

        private void btnAuswertung_Click(object sender, EventArgs e)
        {
            Random Tore = new Random();
            int Summe = 0;
            int ergebnis = 0;
            lblErgebnis.Text = "";
            for (int i = 1; i <= 3; i++)
            {
                int T1 = Tore.Next(0, 8),
                T2 = Tore.Next(0, 8);
                if (T1 > T2)
                {
                    ergebnis = 1;
                }
                else if (T1 == T2)
                {
                    ergebnis = 2;
                }
                else
                {
                    ergebnis = 3;
                }

                Ergebisse[i] = $"{T1}:{T2}";
                lblErgebnis.Text += $"{Spiele[i]}: {Ergebisse[i]} - ";
                if (Tipps[i] == ergebnis)
                {
                    lblErgebnis.Text += "Richtig getippt!\n";
                    Summe++;
                }
                else
                {
                    lblErgebnis.Text += "Leider falsch getippt!\n";
                }
            }
            lblErgebnis.Text += $"{Environment.NewLine}Summe: {Summe}";
        }
       
    }
}
