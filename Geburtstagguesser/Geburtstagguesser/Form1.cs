namespace Geburtstagguesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++) //iteriere von 1 (i =1) bis i die 7 durch i ++ erreicht
                cmb_zahl.Items.Add(i) //addiere ein combobox eintrag mit der derzeitige Schleifendurchgang (i=xyz)
                ;
            // cmb_zahl.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            btn_ausrechnen.Enabled = false;
        }

        private void checkreq()
        {
            btn_ausrechnen.Enabled =
                cmb_zahl.Text != null &&
                txt_geburtsjahr.Text != null &&
                radiobtn_ja.Checked || radiobtn_nein.Checked;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ausrechnen_Click(object sender, EventArgs e)
        {
            int zahl = Int32.Parse(cmb_zahl.Text); //wandel das Text von der combobox zu einen integer
            zahl *= 2; // {
            zahl += 5; //   selbsterklärend
            zahl *= 50; // }
            if (radiobtn_ja.Checked) // wenn radio button ist als Ja angeklickt
                zahl += 1776;
            else if (radiobtn_nein.Checked) // sonst (nein angeklickt oder gar nicht)
                zahl += 1775;
            zahl -= Int32.Parse(txt_geburtsjahr.Text); // dein Geburtsjahr zu integer wandeln

            lbl_deinezahl1.Text = zahl.ToString(); // wandel das Integer zu string und ändere das Labeltext zu Zahl
        }

        private void radiobtn_ja_CheckedChanged(object sender, EventArgs e)
        {
            checkreq();
        }

        private void radiobtn_nein_CheckedChanged(object sender, EventArgs e)
        {
            checkreq();
        }

        private void cmb_zahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkreq();
        }

        private void txt_geburtsjahr_TextChanged(object sender, EventArgs e)
        {
            checkreq();
        }
    }
}
